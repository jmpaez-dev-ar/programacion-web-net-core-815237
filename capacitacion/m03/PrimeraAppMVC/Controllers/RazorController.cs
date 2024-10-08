using Microsoft.AspNetCore.Mvc;

namespace PrimeraAppMVC.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
			ViewBag.Nombre = "José";
			TempData["Apellido"] = "Pérez";

			ViewData["Date"] = DateTime.Now.ToString("dd/MM/yyyy");

			ViewData["MonthHalf"] = DateTime.Now.Day <= 15 ? "Estamos en la primer mitad del mes" : "Estamos en la segunda mitad del mes";

			ViewData["Cursos"] = new string[]
			{
				"C# para no programadores",
				"Introducción al Paradigma de Objetos",
				"HTML5: Fundamentos web",
				"Programación ASP .Net MVC"
			};


			return View();
        }
    }
}
