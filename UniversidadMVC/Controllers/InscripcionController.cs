using Microsoft.AspNetCore.Mvc;

namespace UniversidadMVC.Controllers
{
    public class InscripcionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
