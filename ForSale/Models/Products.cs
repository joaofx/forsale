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