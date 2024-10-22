using GestionComercial.Data.Data;
using GestionComercial.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GestionComercial.Web.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly GestionComercialDbContext _context;

        public VendedoresController(GestionComercialDbContext context)
        {
            _context = context;
        }

        // GET: Vendedores
        public async Task<IActionResult> Index()
        {
            var gestionComercialDbContext = _context.Vendedores.Include(v => v.Domicilio).Include(v => v.TipoDocumento);
            return View(await gestionComercialDbContext.ToListAsync());
        }

        // GET: Vendedores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedor = await _context.Vendedores
                .Include(v => v.Domicilio)
                .Include(v => v.TipoDocumento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendedor == null)
            {
                return NotFound();
            }

            return View(vendedor);
        }

        // GET: Vendedores/Create
        public IActionResult Create()
        {
            ViewData["DomicilioId"] = new SelectList(_context.Domicilios, "Id", "Calle");
            ViewData["TipoDocumentoId"] = new SelectList(_context.TiposDocumento, "Id", "Codigo");
            return View();
        }

        // POST: Vendedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Apellido,Nombre,FechaNacimiento,FechaContratacion,Telefono,Celular,Email,TipoDocumentoId,NumeroDocumento,DomicilioId")] Vendedor vendedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DomicilioId"] = new SelectList(_context.Domicilios, "Id", "Calle", vendedor.DomicilioId);
            ViewData["TipoDocumentoId"] = new SelectList(_context.TiposDocumento, "Id", "Codigo", vendedor.TipoDocumentoId);
            return View(vendedor);
        }

        // GET: Vendedores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedor = await _context.Vendedores.FindAsync(id);
            if (vendedor == null)
            {
                return NotFound();
            }
            ViewData["DomicilioId"] = new SelectList(_context.Domicilios, "Id", "Calle", vendedor.DomicilioId);
            ViewData["TipoDocumentoId"] = new SelectList(_context.TiposDocumento, "Id", "Codigo", vendedor.TipoDocumentoId);
            return View(vendedor);
        }

        // POST: Vendedores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Apellido,Nombre,FechaNacimiento,FechaContratacion,Telefono,Celular,Email,TipoDocumentoId,NumeroDocumento,DomicilioId")] Vendedor vendedor)
        {
            if (id != vendedor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendedorExists(vendedor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DomicilioId"] = new SelectList(_context.Domicilios, "Id", "Calle", vendedor.DomicilioId);
            ViewData["TipoDocumentoId"] = new SelectList(_context.TiposDocumento, "Id", "Codigo", vendedor.TipoDocumentoId);
            return View(vendedor);
        }

        // GET: Vendedores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedor = await _context.Vendedores
                .Include(v => v.Domicilio)
                .Include(v => v.TipoDocumento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendedor == null)
            {
                return NotFound();
            }

            return View(vendedor);
        }

        // POST: Vendedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendedor = await _context.Vendedores.FindAsync(id);
            if (vendedor != null)
            {
                _context.Vendedores.Remove(vendedor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendedorExists(int id)
        {
            return _context.Vendedores.Any(e => e.Id == id);
        }
    }
}
