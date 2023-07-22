

using Casgem_CQRS.CQRS.Commands;
using Casgem_CQRS.DAL;

namespace Casgem_CQRS.CQRS.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;
        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.Brand = command.Brand;
            values.Price = command.Price;
            values.Stock = command.Stock;
            values.Category = command.Category;
            values.Name = command.Name;
            _context.SaveChanges();
        }
    }
}
