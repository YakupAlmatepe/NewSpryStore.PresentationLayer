using Microsoft.AspNetCore.Mvc;

namespace NewSpryStore.PresentationLayer.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
