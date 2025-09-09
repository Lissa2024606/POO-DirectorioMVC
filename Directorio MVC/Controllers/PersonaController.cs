using Microsoft.AspNetCore.Mvc;

namespace Directorio_MVC.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
