

using Casgem_CQRS.CQRS.Queries;
using Casgem_CQRS.CQRS.Results;
using Casgem_CQRS.DAL;

namespace Casgem_CQRS.CQRS.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;
        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductByIDQueryResult
            {
                ProductID = values.ProductID,
                ProductMark = values.Brand,
                ProductName = values.Name
            };
        }
    }
}
