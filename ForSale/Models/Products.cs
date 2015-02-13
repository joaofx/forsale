using System.Collections.Generic;
using System.Linq;

namespace ForSale.Models
{
    public class Products
    {
        private static readonly List<Product> Items;

        static Products()
        {
            Items = new List<Product>
            {
                ProductFixture.CreateTelefone(),
                ProductFixture.CreateCama(),
                ProductFixture.CreateSofa(),
                ProductFixture.CreateFogao(),
                ProductFixture.CreateGeladeira()
            };
        }

        public static List<Product> All()
        {
            return Items;
        }

        public static Product ById(string id)
        {
            return Items.FirstOrDefault(x => x.Id == id);
        }
    }
}