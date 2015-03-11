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
                ProductFixture.CreateCriadoGrande(),
                ProductFixture.CreateCriadoPequeno(),
                

                // cozinha
                ProductFixture.CreateFogao(),
                ProductFixture.CreateGeladeira(),
                ProductFixture.CreateConjuntoCha(),

                // eletro eletrônicos
                ProductFixture.CreateLavadora(),
                ProductFixture.CreateTelefone(),
                
                // música
                ProductFixture.CreateAmplificador(),
                ProductFixture.CreateBota(),
                

                ProductFixture.CreateEstante(),
                ProductFixture.CreateLine6(),
                ProductFixture.CreateMemoria(),
                ProductFixture.CreateMesa(),
                ProductFixture.CreateNotebook(),
                ProductFixture.CreateRack(),
                ProductFixture.CreateSuporteViolao(),
                ProductFixture.CreateViolaoAco(),
                ProductFixture.CreateViolaoNylon(),
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