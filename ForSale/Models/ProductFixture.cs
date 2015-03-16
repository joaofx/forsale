using System.Collections.Generic;

namespace ForSale.Models
{
    public class ProductFixture
    {
        const string Eletronicos = "Eletronicos";
        const string Moveis = "Moveis";
        const string Eletrodomesticos = "Eletrodomesticos";
        const string Musica = "Musica";
        const string Diversos = "Diversos";
        const string Cozinha = "Cozinha";
        const string Informatica = "Informatica";

        public static Product CreateTelefone()
        {
            return new Product
            {
                Id = "Telefone",
                Title = "Telefone fixo com fio Intelbras",
                Price = 1,
                Tag = Eletronicos,
                LocalThumbnail = "IMG_1374",
                RemoteImages = new List<string>() { "hfXnaOB", "5hX2Ha1" },
                RemoteThumbnail = "t2XYFE2",
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
                Price = 430,
                Tag = Moveis,
                RemoteThumbnail = "07RZrE9",
                RemoteImages = new List<string> { "m9ZgCC7", "VlhfyQ1", "x5Vi3sh", "rdIyDK4", "d9Oj06Z" },
                LocalThumbnail = "IMG_1287",
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
                Price = 270,
                Tag = Moveis,
                LocalThumbnail = "IMG_1309",
                RemoteImages = new List<string> { "c95VvXx", "yMNMIhC", "YmNaDeZ", "2jqr2Wk", "SlSTVQx" },
                RemoteThumbnail = "1cv4vvj",
                Description = @"
Sofá de 2 Lugares. Acompanha 5 almofadas da Etna.

ESTADO:
Dono único e 6 anos de uso. Está bem conservado. O ziper de uma das almofadas está estragado.

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
                Price = 170,
                Tag = Eletrodomesticos,
                LocalThumbnail = "IMG_1293",
                RemoteImages = new List<string> { "aVeDlCZ", "vQrMjug", "DJDwU66", "qn96hm7"},
                RemoteThumbnail = "YsjvstC",
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
                Tag = Eletrodomesticos,
                LocalThumbnail = "IMG_1298",
                RemoteImages = new List<string>() { "PY0kITz", "8rEemhS", "IYEYvy3", "bHhrbnp", "" },
                RemoteThumbnail = "WOsoaco",
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
                Tag = Eletrodomesticos,
                LocalThumbnail = "IMG_1304",
                RemoteImages = new List<string>() { "qHTDiyH", "Vx4UsCZ", "PRkxBye", "LyhAs1f", "pOxiOXN" },
                RemoteThumbnail = "gb56w15",
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
                Id = "Amp",
                Title = "Amplificador de Baixo Meteoro",
                Price = 1,
                Tag = Musica,
                LocalThumbnail = "IMG_1313",
                RemoteImages = new List<string> { "8H8Aj3B", "x3CXyON", "ILfj2JD", "IDEIS4Y" },
                RemoteThumbnail = "8Amhf2h",
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
                Tag = Diversos,
                LocalThumbnail = "IMG_1379",
                RemoteImages = new List<string> { "GOgOdlP", "MDuyIk3", "XXHwC9D", "bhtPPoT" },
                RemoteThumbnail = "hzXTLtf",
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
                Tag = Cozinha,
                LocalThumbnail = "IMG_1370",
                RemoteImages = new List<string> { "8pI5BsM", "Ms9e40v", "JAjFdqz", "NPhP764" },
                RemoteThumbnail = "j14eBpD",
                Description = @"
Conjunto de Chá da Turquia (Chay)

* Contém 6 xicaras
* Comprado na Turquia (Istambul)

ESTADO:
Na caixa. Nunca foi usado.

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
                Tag = Moveis,
                LocalThumbnail = "IMG_1341",
                RemoteImages = new List<string> { "zIdQnUA", "HsIjyM5", "QWOjiiT", "rNF3hSf" },
                RemoteThumbnail = "9UmJB3G",
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
                Tag = Moveis,
                LocalThumbnail = "IMG_1345",
                RemoteImages = new List<string> { "BM20NCC", "GATZR7U", "sO1wP7a", "" },
                RemoteThumbnail = "OP6GSSQ",
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
                Tag = Moveis,
                LocalThumbnail = "IMG_1338",
                RemoteImages = new List<string> { "ijGEXvf", "SzADl3M", "TZICBRv" },
                RemoteThumbnail = "ein6r3l",
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
                Tag = Musica,
                LocalThumbnail = "IMG_1376",
                RemoteImages = new List<string>() { "glBKkzg", "3pOU8jF", "Kp9GXeM" },
                RemoteThumbnail = "RjPshAp",
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
                Tag = Informatica,
                LocalThumbnail = "IMG_1355",
                RemoteThumbnail = "DU3Mm6C",
                RemoteImages = new List<string>() { "xfIOSrH", "eEQWG5G"},
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
                Title = "Mesa de Jantar com 4 Cadeiras",
                Price = 1,
                Tag = Moveis,
                LocalThumbnail = "IMG_1349",
                RemoteThumbnail = "ESBy5N3",
                RemoteImages = new List<string>() { "Gurugqz", "NFFWqVp", "rsUqLNX", "DMFW08B", "O6GSdcj" },
                Description = @"
Mesa de Jantar

* Aproximadamente 1,10 x 0,76m
* Tampo de vidro fosco
* 4 Cadeiras acolchoadas

ESTADO:
Bem conservado.

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
                Tag = Informatica,
                LocalThumbnail = "IMG_1359",
                RemoteImages = new List<string>() { "r2tAmpJ", "1pJann8", "3gMjCbF", "zVDtfWV", "9qL5CCP", "YOXqfIx", "P21mp64", "1zHlIOX" },
                RemoteThumbnail = "DAy14yU",
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
                Tag = Moveis,
                LocalThumbnail = "IMG_1318",
                RemoteThumbnail = "Wu86RUM",
                RemoteImages = new List<string>() { "dI2e9Eg", "HZ9Pjgp", "fcsag0p" },
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
                Tag = Musica,
                LocalThumbnail = "IMG_1335",
                RemoteImages = new List<string>() { "rxY2mL3", "alLFy1C", "I8GzE6A" },
                RemoteThumbnail = "YPJqBiO",
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
                Tag = Musica,
                LocalThumbnail = "IMG_1329",
                RemoteImages = new List<string>() { "NpsYr5M", "iey97J5", "S3hXdSo", "zAvGGJv" },
                RemoteThumbnail = "Dv8UWxa",
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
                Tag = Musica,
                LocalThumbnail = "IMG_1323",
                RemoteImages = new List<string>() { "XWFdwly", "fC8TDCo", "W8JPt7P" },
                RemoteThumbnail = "43CNjTs",
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

        public static Product CreateRoteadorWifi()
        {
            return new Product
            {
                Id = "Wifi",
                Title = "Roteador Wifi Siroco",
                Price = 1,
                Tag = Informatica,
                LocalThumbnail = "IMG_1366",
                RemoteImages = new List<string>() { "gGArOvp", "wTHxFNy", "ljsOR4T" },
                RemoteThumbnail = "NPoQUVM",
                Description = @"
Roteador Wifi Siroco

* Roteador Wireless
* 4 Portas Ethernet
* Fonte Bivolt
* Acompanha Manual
* Acompanha Nota Fiscal

ESTADO:
Bem conservado. Foi pouco usado.

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial.
",
            };
        }
    }
}