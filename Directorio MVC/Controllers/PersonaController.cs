using Microsoft.AspNetCore.Mvc;
using Directorio_MVC.Models;
namespace Directorio_MVC.Controllers
{
    public class PersonaController : Controller
    {
        Persona myPersona = new Persona("Jose","Morazan");


        public IActionResult Index()
        {
            return View(myPersona);
        }
    }
}
