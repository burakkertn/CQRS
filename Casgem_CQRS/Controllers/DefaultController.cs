using Casgem_CQRS.CQRS.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _handler;

        public DefaultController(GetProductQueryHandler handler)
        {
            _handler = handler;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }
    }
}
