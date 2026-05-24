using Microsoft.AspNetCore.Mvc;

namespace TiendaApp.Controllers
{
    public class ProductosController : Controller
    {
        public ProductosController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
