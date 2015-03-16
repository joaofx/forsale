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
                Price = 450,
                Tags = new List<string> {"Móveis"},
                RemoteImages = new List<string> { "m9ZgCC7", "VlhfyQ1", "x5Vi3sh", "rdIyDK4", "d9Oj06Z" },
                Thumbnail = "07RZrE9",
                LocalImages = new List<string> { "IMG_1287", "IMG_1286", "IMG_1288", "IMG_1289", "IMG_1290" },
                LocalImagesDirectory = @"D:\Fotos\_Sale_\Cama",
                Description = @"
Kit Conjunto Box

* Base + Colchão
* Modelo Luckspuma Pocket New Luck Spring
* Tamanho 138x188
* Molas ensacadas tipo barril 
* Acompanha Nota Fiscal

Se o comprador quiser posso dar os travesseiros também.

ESTADO:
Dono único. Está bem conservado, com dois pequenos desgaste no colchão.

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

        public static Product CreateLavadora()
        {
            return new Product
            {
                Id = "Lavadora",
                Title = "Máquina de Lavar Roupa Brastemp 9Kg",
                Price = 1,
                Tags = new List<string> { "Eletrodomésticos" },
                Description = @"
Máquina de Lavar Roupa Brastemp 9Kg

* 220v
* Modo de Centrifugar
* Mecânica
* Acompanha Nota Fiscal
* Acompanha Manual

ESTADO:
Está bem conservado. 

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateAmplificador()
        {
            return new Product
            {
                Id = "Amplificador",
                Title = "Amplificador de Baixo Meteoro",
                Price = 1,
                Tags = new List<string> { "Música" },
                Description = @"
Amplificador de Baixo Meteoro

* Chave manual para trocar 110v/220v

ESTADO:
O som está bom. A alça está sem um parafuso. Alguns botões de regulagem estão sem capa como você pode ver nas fotos.

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateBota()
        {
            return new Product
            {
                Id = "Bota",
                Title = "Bota Ortopédica",
                Price = 1,
                Tags = new List<string> { "Saúde" },
                Description = @"
Bota Ortopédica G

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateConjuntoCha()
        {
            return new Product
            {
                Id = "Cha",
                Title = "Conjunto de Chá da Turquia (Chay)",
                Price = 1,
                Tags = new List<string> { "???" },
                Description = @"
Conjunto de Chá da Turquia (Chay)

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateCriadoGrande()
        {
            return new Product
            {
                Id = "CriadoGrande",
                Title = "Criado Mudo",
                Price = 1,
                Tags = new List<string> { "Móveis" },
                Description = @"
Criado Mudo.

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateCriadoPequeno()
        {
            return new Product
            {
                Id = "CriadoPequeno",
                Title = "Criado Pequeno",
                Price = 1,
                Tags = new List<string> { "Móveis" },
                Description = @"
Criado Mudo.

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateEstante()
        {
            return new Product
            {
                Id = "Estante",
                Title = "Estante de Livros",
                Price = 1,
                Tags = new List<string> { "Móveis" },
                Description = @"
Criado Mudo.

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateLine6()
        {
            return new Product
            {
                Id = "Line6",
                Title = "Line6",
                Price = 1,
                Tags = new List<string> { "Móveis" },
                Description = @"
Line 6

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateMemoria()
        {
            return new Product
            {
                Id = "Memoria",
                Title = "Memória",
                Price = 1,
                Tags = new List<string> { "Móveis" },
                Description = @"
Memória

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateMesa()
        {
            return new Product
            {
                Id = "Mesa",
                Title = "Mesa de Jantar",
                Price = 1,
                Tags = new List<string> { "Móveis" },
                Description = @"
Mesa de Jantar

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateNotebook()
        {
            return new Product
            {
                Id = "Notebook",
                Title = "Notebook Acer",
                Price = 1,
                Tags = new List<string> { "Eletrônicos" },
                Description = @"
Notebook

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateRack()
        {
            return new Product
            {
                Id = "Rack",
                Title = "Rack",
                Price = 1,
                Tags = new List<string> { "Móveis" },
                Description = @"
Rack

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateSuporteViolao()
        {
            return new Product
            {
                Id = "SuporteViolao",
                Title = "Suporte Para Violão",
                Price = 1,
                Tags = new List<string> { "Música" },
                Description = @"
Suporte Para Violão

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateViolaoAco()
        {
            return new Product
            {
                Id = "ViolaoAco",
                Title = "Violão de Aço",
                Price = 1,
                Tags = new List<string> { "Música" },
                Description = @"
Violão de Aço

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }

        public static Product CreateViolaoNylon()
        {
            return new Product
            {
                Id = "ViolaoNylon",
                Title = "Violão de Nylon",
                Price = 1,
                Tags = new List<string> { "Música" },
                Description = @"
Violão de Nylon

ESTADO:

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }
    }
}