using Microsoft.AspNetCore.Mvc;
using PrimeraAppMVC.Models;

namespace PrimeraAppMVC.Controllers
{
	public class ArticulosController : Controller
	{
		public IActionResult Index()
		{
			var articulo = new Articulo { Id =1, Nombre = "Articulo 1", Descripcion = "Articulo 1", Precio = 100 };

			return View(articulo);
		}


		public IActionResult Details()
		{
			var articulo = new Articulo { Id = 2, Nombre = "Articulo 2", Descripcion = "Articulo 2", Precio = 200 };

			return View(articulo);
		}
	}
}
