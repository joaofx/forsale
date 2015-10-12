using System;
using System.Linq;
using System.Linq.Expressions;
using FluentValidation;
using ForSale.DependencyResolution;
using ForSale.Infrastructure;
using MediatR;
using NUnit.Framework;
using StructureMap;

namespace ForSale.Tests
{
    public class IntegratedTest
    {
        private static bool _initialized;
        private IContainer _scopedContainer;

        [TestFixtureSetUp]
        public void BeforeAllTests()
        {
            if (_initialized) return;

            IoC.ParentScope = IoC.Initialize(c =>
            {
                c.AddRegistry<TestRegistry>();
                c.AddRegistry<CommandRegistry>();
                c.AddRegistry<InfrastructureRegistry>();
            });

            DatabaseMigration.Update();

            _initialized = true;
        }

        [SetUp]
        public void BeforeEachIntegratedTest()
        {
            IoC.ParentScope.GetInstance<IDatabaseCleaner>().Clean();
        }

        [TearDown]
        public void AfterEachIntegreatedTest()
        {
        }

        public void WithDb(Action action)
        {
            WithDb(db => action());
        }

        public void WithDb(Action<ApplicationContext> action)
        {
            using (_scopedContainer = IoC.ParentScope.GetNestedContainer())
            {
                using (var db = _scopedContainer.GetInstance<ApplicationContext>())
                {
                    try
                    {
                        db.BeginTransaction();
                        action(db);
                        db.CloseTransaction();
                    }
                    catch (Exception e)
                    {
                        db.CloseTransaction(e);
                        throw;
                    }
                }
            }
        }

        public void Save(params object[] entities)
        {
            WithDb(db =>
            {
                foreach (var entity in entities)
                {
                    var entry = db.ChangeTracker.Entries().FirstOrDefault(entityEntry => entityEntry.Entity == entity);

                    if (entry == null)
                    {
                        db.Set(entity.GetType()).Add(entity);
                    }
                }

                db.SaveChanges();
            });
        }
        
        protected void Send(IRequest message)
        {
            Send((IRequest<Unit>)message);
        }

        protected void ShouldThrow<T>(IRequest message) where T : Exception
        {
            Assert.Throws<T>(() => Send((IRequest<Unit>)message));
        }

        protected TResult Send<TResult>(IRequest<TResult> message, bool asNonPullStep = false)
        {
            var result = default(TResult);

            WithDb(db =>
            {
                var mediator = _scopedContainer.GetInstance<IMediator>();
                result = mediator.Send(message);
            });

            return result;
        }

        protected void ShouldBeInvalid<TCommand, TProperty>(TCommand command, Expression<Func<TCommand, TProperty>> property) where TCommand : IRequest
        {
            var expression = (MemberExpression)property.Body;
            var propertyName = expression.Member.Name;
            var commandName = typeof(TCommand).Name;

            try
            {
                Send(command);
                Assert.Fail($"'{propertyName}' should be invalid but the Validator did not found ANY error on the Command '{commandName}'");
            }
            catch (ValidationException ex)
            {
                if (ex.Errors.Any(x => x.PropertyName == propertyName) == false)
                {
                    var errors = ex.Errors.JoinTo(Environment.NewLine, x => $"Property {x.PropertyName}, Error: {x.ErrorMessage}");
                    var msg = $@"Property '{propertyName}' of the Command '{commandName}' should be invalid but the Validator did not found error for this.

Errors found:

${errors}";
                    Assert.Fail(msg);
                }
            }
        }
    }
}