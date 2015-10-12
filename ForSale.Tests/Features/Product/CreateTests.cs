using System.Linq;
using ForSale.Features.Products;
using NUnit.Framework;
using Should;

namespace ForSale.Tests.Features.Product
{
    [TestFixture]
    public class CreateTests : IntegratedTest
    {
        [Test]
        public void Should_save()
        {
            // arrange
            var command = new Create.Command
            {
                Name = "Condor Viola Bass",
                Price = 800.5m
            };

            // act
            Send(command);

            // assert
            WithDb(db =>
            {
                var saved = db.Products.Single();
                saved.Name.ShouldEqual(command.Name);
                saved.Price.ShouldEqual(saved.Price);
            });
        }
    }
}
