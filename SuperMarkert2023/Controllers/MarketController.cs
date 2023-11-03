using Microsoft.AspNetCore.Mvc;
using Aplication.ViewModel;
using Aplication.Services;

namespace SuperMarkert2023.Controllers
{
    public class MarketController : Controller
    {
        ProductService productService;

        public MarketController()
        {
            productService = new ProductService();
        }

        //GET
        public IActionResult Index()
        {
            return View(productService.GetProducts());
        }

        public IActionResult Create()
        {
            return View();
        
        }

        [HttpPost]
        public IActionResult Create(CreateProductViewModel cpvm)
        {
            productService.Add(cpvm);

            //return RedirectToAction("Index"); solo se puede utilizar en el mismo controlador
            return RedirectToRoute(new { controller = "Market", action = "index" });

        }
    }
}
