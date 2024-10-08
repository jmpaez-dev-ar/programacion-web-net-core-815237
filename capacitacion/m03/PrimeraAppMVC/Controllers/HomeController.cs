using Microsoft.AspNetCore.Mvc;
using PrimeraAppMVC.Models;
using System.Diagnostics;

namespace PrimeraAppMVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Mensaje()
		{
			return View();
		}


		//public string IndexParm(string nombre)
		//{
		//	return "Hola " + nombre;

		//}

		public string IndexHtml()
		{
			return @"< html >< body >< h1 > ACME S.R.L.</ h1 >< p > Una organización a su servicio, para resolver
			cualquier problema </ p ></ body ></ html >";
		}

		public string IndexTxt()
		{
			string mensaje = @"
            Bienvenido a Comercio IT \n
            Estamos encantados de tenerte aquí. Descubre nuestros servicios y productos.
            ";
			return mensaje;
		}


		public string IndexJson()
		{
			string mensajeJson = @"
        {
            ""categorias"": [
                ""Computadoras y Laptops"",
                ""Periféricos y Accesorios"",
                ""Componentes Internos"",
                ""Almacenamiento y Memoria"",
                ""Software y Licencias""
            ]
        }";
			return mensajeJson;
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
