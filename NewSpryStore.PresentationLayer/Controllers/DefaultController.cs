using Microsoft.AspNetCore.Mvc;
using NewSpryStore.DataAccessLayer.Concrete;
using System.Linq;

namespace NewSpryStore.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
    }
}
