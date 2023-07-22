using Casgem_CQRS.CQRS.Results;
using Casgem_CQRS.DAL;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Casgem_CQRS.CQRS.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                Brand = x.Brand,
                Category = x.Category,
                Price = x.Price,
                ProductID = x.ProductID,    
                Stock = x.Stock,


            }).ToList();
            return values;
        }
    }
}
