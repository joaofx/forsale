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

        public static Product CreateArteDevAgil()
        {
            return new Product
            {
                Id = "Arte-Agil",
                Title = "A Arte Do Desenvolvimento Ágil",
                Price = 15,
                LocalThumbnail = "IMG_1366",
                RemoteImages = new List<string>() { "1BRewAq" },
                RemoteThumbnail = "UeYbRfK",
                Description = @"
“Deixarei uma cópia deste livro com cada equipe que eu visitar.”
—Brian Marick, Consultor de Padrões

Um guia prático para qualquer pessoa que esteja utilizando o desenvolvimento ágil para construir um software valioso, este livro descreve o que é o desenvolvimento ágil e por que ele ajuda os projetos de software a serem bem sucedidos. Combina informações para desenvolvedores, gerentes, testadores e clientes em um único pacote que pode ser diretamente aplicado.

A Arte do Desenvolvimento Ágil oferece uma visão completa do processo ágil, inclusive conselhos diretos sobre planejamento, desenvolvimento, entrega e gerenciamento baseados nos anos de experiência dos autores com Programação Extrema (XP). Este livro fornece práticas aplicadas para desenvolvedores e testadores, bem como informações para leitores não-técnicos. Os autores também tratam de um aspecto difícil do desenvolvimento ágil: desenvolver a cooperação e a confi ança entre os membros da equipe.

A Arte do Desenvolvimento Ágil fornece respostas claras para perguntas como:

* Como podemos adotar o desenvolvimento ágil?
* Precisamos, realmente, fazer programação em pares?
* Quais métricas devemos reportar?
* Como podemos fazer para que os clientes participem?
* Quanta documentação deve ser escrita?
* Quando projetar e arquitetar?
* Como não-desenvolvedor, como eu poderia trabalhar com uma equipe ágil?
* Onde está o roadmap do meu produto?
* Onde se encaixa a Garantia de Qualidade?
* Se você já faz parte de uma equipe ágil ou se está apenas interessado no desenvolvimento ágil, este livro traz as dicas práticas de que você precisa. Explica como adotar as práticas XP, descreve cada uma delas e discute princípios que permitem a você modifi car e criar seu método XP. Este livro crescerá com você, conforme você adquire experiência, primeiro ensinando as regras, depois, como quebrá-las e, fi nalmente, como abandonar as regras conforme você se aperfeiçoa na arte do desenvolvimento ágil.

ESTADO:
Bem conservado. Foi pouco usado.

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial ou combinar retirada na Asa Norte ao lado do Conjunto Nacional.
",
            };
        }

        public static Product CreateNaoMeFacaPensar()
        {
            return new Product
            {
                Id = "Nao-Me-Faca",
                Title = "Não Me Faça Pensar - Usabilidade na Web",
                Price = 10,
                RemoteImages = new List<string>() { "l1eIk2c" },
                RemoteThumbnail = "H2Ckdct",
                Description = @"
Livro - Não Me faça Pensar - Usabilidade na Web - 2ºed. - 100% colorido

Uma Abordagem de Bom Senso à Usabilidade na Web. Cinco anos e mais de 100 mil exemplares após ter sido publicado pela primeira vez, é difícil imaginar alguém trabalhando em projeto Web que não tenha lido o 'clássico instantâneo' de Steve Krug sobre usabilidade na Web; contudo, as pessoas ainda o estão descobrindo todos os dias. Nesta segunda edição, Steve acrescenta três novos capítulos no mesmo estilo do original: divertido e interessante, mas, ainda assim, cheio de informações e conselhos práticos, tanto para novatos quanto para veteranos. Não fique surpreso se ele mudar completamente a forma pela qual você pensa em projeto para Web.

ESTADO:
Bem conservado. Foi pouco usado.

PAGAMENTO:
À vista em dinheiro.

RETIRADA:
Buscar no Guará I em horário não comercial ou combinar retirada na Asa Norte ao lado do Conjunto Nacional.
",
            };
        }
    }
}