using ForSale.Infrastructure;
using ForSale.Models;
using MediatR;

namespace ForSale.Features.Products
{
    public class Create
    {
        public class Command : IRequest
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Handler : RequestHandler<Command>
        {
            private readonly ApplicationContext _db;

            public Handler(ApplicationContext db)
            {
                _db = db;
            }

            protected override void HandleCore(Command message)
            {
                _db.Products.Add(new Product
                {
                    Name = message.Name,
                    Price = message.Price
                });
            }
        }
    }
}