using System.Collections.Generic;

namespace ForSale.Models
{
    public class ProductFixture
    {
        public static Product CreateTelefone()
        {
            return new Product
            {
                Id = "Telefone",
                Title = "Telefone fixo com fio Intelbras",
                Price = 1,
                ImagemId = "mw57pqv",
                AlbumId = "n5Y83",
                Tags = new List<string> {"Eletrônico"},
                Description = @"
ESTADO:
Quase novo. Foi muito pouco usado.

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Podemos combinar.
No horário comercial fico na Asa Norte ao lado do Conjunto Nacional no horário comercial, nos outros horários no Guará I.
",
            };
        }

        public static Product CreateCama()
        {
            return new Product
            {
                Id = "Cama",
                Title = "Cama de Casal Box Com Base e Colchão",
                Price = 1,
                ImagemId = "Rri6uOO",
                AlbumId = "72PeL",
                Tags = new List<string> {"Eletrônico"},
                Description = @"
Kit Conjunto Box: Colchão Luckspuma Pocket New Luck Spring, 138x188. Composta pela base e pelo colchão. Se o comprador quiser posso dar os travesseiros também.

Cama recomendada para quem gosta de colchão mais firme.

ESTADO:
Dono único. Está bem conservado, com dois pequenos desgaste no colchão. Acompanha Nota Fiscal.

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateSofa()
        {
            return new Product
            {
                Id = "Sofa",
                Title = "Sofá de 2 Lugares",
                Price = 1,
                ImagemId = "WSyd7qw",
                AlbumId = "PzpzF",
                Tags = new List<string> {"Móveis"},
                Description = @"
Sofá de 2 Lugares. Acompanha 5 almofadas da Etna.

ESTADO:
Dono único e 6 anos de uso. Está bem conservado, porém o ziper de uma das almofadas está estragado, e precisa de limpeza.

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateFogao()
        {
            return new Product
            {
                Id = "Fogao",
                Title = "Fogão Atlas Tropical 4 Bocas + Gás",
                Price = 1,
                ImagemId = "6OWWdod",
                AlbumId = "eaLly",
                Tags = new List<string> {"Eletrodomésticos"},
                Description = @"
Fogão Atlas Tropical 4 Bocas

* Elétrico
* Forno
* Válvula de segurança para ligar o Forno
* Acompanha Mangueira do Gás
* Acompanha Gás (deve estar no final)
* Nota Fiscal
* Manual

ESTADO:
Dono único e 6 anos de pouco uso. Está bem conservado.

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateGeladeira()
        {
            return new Product
            {
                Id = "Geladeira",
                Title = "Geladeira Consul 240",
                Price = 1,
                ImagemId = "dAO9G3y",
                AlbumId = "bB08m",
                Tags = new List<string> {"Eletrodomésticos"},
                Description = @"
Geladeira Consul 240

* 220v
* Freezer

ESTADO:
Está bem conservado.

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }
    }
}