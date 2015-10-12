using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ForSale.Infrastructure;
using ForSale.Models;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Kernel;

namespace ForSale.Tests
{
    public static class Fixtures
    {
        public static Fixture Fixture { get; set; }

        static Fixtures()
        {
            Fixture = new Fixture();

            Fixture.Customizations.Add(new IdOmitterBuilder());
            Fixture.Customizations.Add(new CollectionPropertyOmitter());

            Fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            Fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }

        public static T Create<T>(params Action<T>[] composers)
        {
            var item = Fixture.Create<T>();

            foreach (var compose in composers)
            {
                compose?.Invoke(item);
            }

            return item;
        }

        public static T CreateAndSave<T>(params Action<T>[] composer) where T : Entity
        {
            var item = Create(composer);

            using (var db = IoC.Container.GetInstance<ApplicationContext>())
            {
                db.Set<T>().Add(item);
                db.SaveChanges();
            }

            return item;
        }
    }

    public class OmitListBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var pi = request as PropertyInfo;

            if (pi != null)
            {
                var isIEnumerable = pi.PropertyType
                    .GetInterfaces()
                    .Any(t => t.IsGenericType && (
                        t.GetGenericTypeDefinition() == typeof(IList<>) ||
                        t.GetGenericTypeDefinition() == typeof(ICollection<>)));

                if (isIEnumerable)
                {
                    if (pi.PropertyType.IsArray)
                    {
                        return Array.CreateInstance(pi.PropertyType.GetElementType(), 0);
                    }

                    var genericArguments = pi.PropertyType.GetGenericArguments();
                    var concreteType = typeof(List<>).MakeGenericType(genericArguments);
                    var instance = Activator.CreateInstance(concreteType);
                    return instance;
                }
            }

            return new NoSpecimen(request);
        }
    }

    public class CollectionPropertyOmitter : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var pi = request as PropertyInfo;
            if (pi != null
                && pi.PropertyType.IsGenericType
                && pi.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>))
                return new OmitSpecimen();

            return new NoSpecimen(request);
        }
    }

    public class IdOmitterBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var property = request as PropertyInfo;

            if (property == null)
            {
                return new NoSpecimen(request);
            }

            if (IsId(property))
            {
                return Activator.CreateInstance(property.PropertyType);
            }

            if (IsIdString(property))
            {
                return "0";
            }

            return new NoSpecimen(request);
        }

        private bool IsIdString(PropertyInfo property)
        {
            return property.Name.EndsWith("Id") && property.PropertyType == typeof(string);
        }

        private static bool IsId(PropertyInfo property)
        {
            return property.Name.EndsWith("Id") && (
                property.PropertyType == typeof(long) ||
                property.PropertyType == typeof(long?));
        }
    }
}