using System.Collections.Generic;
using System.Linq;
using Microsoft.Ajax.Utilities;

namespace ForSale.Models
{
    public class Products
    {
        private static readonly List<Product> Items;

        static Products()
        {
            Items = new List<Product>
            {
                // moveis
                ProductFixture.CreateCama(),
                ProductFixture.CreateSofa(),
                ProductFixture.CreateMesa(),
                ProductFixture.CreateEstante(),
                ProductFixture.CreateCriadoGrande(),
                ProductFixture.CreateCriadoPequeno(),
                ProductFixture.CreateRack(),

                //// cozinha
                ProductFixture.CreateFogao(),
                ProductFixture.CreateGeladeira(),
                ProductFixture.CreateConjuntoCha(),

                //// eletro eletrônicos
                ProductFixture.CreateLavadora(),
                ProductFixture.CreateTelefone(),
                
                //// música
                ProductFixture.CreateAmplificador(),
                ProductFixture.CreateLine6(),
                ProductFixture.CreateSuporteViolao(),
                ProductFixture.CreateViolaoAco(),
                ProductFixture.CreateViolaoNylon(),

                //// diversos
                ProductFixture.CreateBota(),
                
                //// informatica
                ProductFixture.CreateMemoria(),
                ProductFixture.CreateNotebook(),
                ProductFixture.CreateRoteadorWifi(),
            };
        }

        public static List<Product> All(string tag = "")
        {
            List<Product> items = Items.OrderByDescending(x => x.Price).ToList();

            if (string.IsNullOrEmpty(tag) == false)
            {
                return items.Where(x => x.Tag == tag).ToList();
            }

            return items;
        }

        public static Product ById(string id)
        {
            return Items.FirstOrDefault(x => x.Id == id);
        }

        public static List<string> Tags()
        {
            return Items.Select(x => x.Tag).DistinctBy(x => x).ToList();
        }
    }
}