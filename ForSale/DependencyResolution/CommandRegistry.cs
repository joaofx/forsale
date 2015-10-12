using FluentValidation;
using ForSale.Infrastructure;
using MediatR;
using StructureMap.Configuration.DSL;

namespace ForSale.DependencyResolution
{
    public class CommandRegistry : Registry
    {
        public CommandRegistry()
        {
            Scan(scan =>
            {
                scan.AssemblyContainingType<IMediator>();
                scan.AssemblyContainingType<CommandRegistry>();

                scan.AddAllTypesOf(typeof(IRequestHandler<,>));
                scan.AddAllTypesOf(typeof(IAsyncRequestHandler<,>));
                scan.AddAllTypesOf(typeof(IValidator<>));
                scan.WithDefaultConventions();
            });

            For<SingleInstanceFactory>().Use<SingleInstanceFactory>(ctx => t => ctx.GetInstance(t));
            For<MultiInstanceFactory>().Use<MultiInstanceFactory>(ctx => t => ctx.GetAllInstances(t));

            var handlerType = For(typeof(IRequestHandler<,>));
            handlerType.DecorateAllWith(typeof(ValidatorHandler<,>));
        }
    }
}