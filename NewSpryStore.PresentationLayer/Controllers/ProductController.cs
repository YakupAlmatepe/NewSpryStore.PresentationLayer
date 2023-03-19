using Microsoft.AspNetCore.Mvc;
using NewSpryStore.BusinessLayer.Abstract;

namespace NewSpryStore.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var values=_productService.TGetList();
            return View(values);
        }
    }
}
