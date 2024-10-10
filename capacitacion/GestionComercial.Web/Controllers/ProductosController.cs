using GestionComercial.Web.Models.Entidades;
using GestionComercial.Web.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionComercial.Web.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ProductoRepositorio _repositorio;

        public ProductosController()
        {
            _repositorio = new ProductoRepositorio();
        }

        // GET: ProductosController
        public ActionResult Index()
        {
            List<Producto> productos = _repositorio.ObtenerTodos();
            return View(productos);
        }

        // GET: ProductosController/Details/5
        public ActionResult Details(int id)
        {
            var producto = _repositorio.ObtenerPorId(id);
			if (producto == null)
			{
				return NotFound();
			}
			return View(producto);
        }

        // GET: ProductosController/Create
        public ActionResult Create()
        {
            var producto = new Producto();
			return View(producto);
        }

        // POST: ProductosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductosController/Edit/5
        public ActionResult Edit(int id)
        {
            var producto = _repositorio.ObtenerPorId(id);
			if (producto == null)
			{
				return NotFound();
			}
			return View(producto);
        }

        // POST: ProductosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductosController/Delete/5
        public ActionResult Delete(int id)
        {
            var producto = _repositorio.ObtenerPorId(id);
			if (producto == null)
			{
				return NotFound();
			}
			return View(producto);
        }

        // POST: ProductosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
