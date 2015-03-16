using System.Collections.Generic;
using System.Linq;
using Microsoft.Ajax.Utilities;

namespace ForSale.Models
{
    public class Products
    {
        const string Eletronicos = "Eletronicos";
        const string Moveis = "Moveis";
        const string Eletrodomesticos = "Eletrodomesticos";
        const string Musica = "Musica";
        const string Diversos = "Diversos";
        const string Cozinha = "Cozinha";
        const string Informatica = "Informatica";
        const string Livros = "Livros";

        private static readonly List<Product> Items;

        static Products()
        {
            Items = new List<Product>
            {
                // moveis
                ProductFixture.CreateCama().WithTag(Moveis),
                ProductFixture.CreateSofa().WithTag(Moveis),
                ProductFixture.CreateMesa().WithTag(Moveis),
                ProductFixture.CreateEstante().WithTag(Moveis),
                ProductFixture.CreateCriadoGrande().WithTag(Moveis),
                ProductFixture.CreateCriadoPequeno().WithTag(Moveis),
                ProductFixture.CreateRack().WithTag(Moveis),

                //// cozinha
                ProductFixture.CreateFogao().WithTag(Cozinha),
                ProductFixture.CreateGeladeira().WithTag(Cozinha),
                ProductFixture.CreateConjuntoCha().WithTag(Cozinha),

                //// eletro eletrônicos
                ProductFixture.CreateLavadora().WithTag(Eletrodomesticos),
                ProductFixture.CreateTelefone().WithTag(Eletrodomesticos),
                
                //// música
                ProductFixture.CreateAmplificador().WithTag(Musica),
                ProductFixture.CreateLine6().WithTag(Musica),
                ProductFixture.CreateSuporteViolao().WithTag(Musica),
                ProductFixture.CreateViolaoAco().WithTag(Musica),
                ProductFixture.CreateViolaoNylon().WithTag(Musica),

                //// diversos
                ProductFixture.CreateBota().WithTag(Diversos),
                
                //// informatica
                ProductFixture.CreateMemoria().WithTag(Informatica),
                ProductFixture.CreateNotebook().WithTag(Informatica),
                ProductFixture.CreateRoteadorWifi().WithTag(Informatica),

                // livros
                ProductFixture.CreateArteDevAgil().WithTag(Livros),
                ProductFixture.CreateNaoMeFacaPensar().WithTag(Livros),
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