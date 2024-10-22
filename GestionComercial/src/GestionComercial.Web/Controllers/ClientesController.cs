using GestionComercial.Data.Data;
using GestionComercial.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GestionComercial.Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly GestionComercialDbContext _context;

        public ClientesController(GestionComercialDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var gestionComercialDbContext = _context.Clientes.Include(c => c.Domicilio).Include(c => c.TipoDocumento);
            return View(await gestionComercialDbContext.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .Include(c => c.Domicilio)
                .Include(c => c.TipoDocumento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewData["DomicilioId"] = new SelectList(_context.Domicilios, "Id", "Calle");
            ViewData["TipoDocumentoId"] = new SelectList(_context.TiposDocumento, "Id", "Codigo");
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,RazonSocial,Apellido,Nombre,FechaNacimiento,Telefono,Celular,Email,TipoDocumentoId,NumeroDocumento,CuitCuil,DomicilioId")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DomicilioId"] = new SelectList(_context.Domicilios, "Id", "Calle", cliente.DomicilioId);
            ViewData["TipoDocumentoId"] = new SelectList(_context.TiposDocumento, "Id", "Codigo", cliente.TipoDocumentoId);
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["DomicilioId"] = new SelectList(_context.Domicilios, "Id", "Calle", cliente.DomicilioId);
            ViewData["TipoDocumentoId"] = new SelectList(_context.TiposDocumento, "Id", "Codigo", cliente.TipoDocumentoId);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,RazonSocial,Apellido,Nombre,FechaNacimiento,Telefono,Celular,Email,TipoDocumentoId,NumeroDocumento,CuitCuil,DomicilioId")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
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
            ViewData["DomicilioId"] = new SelectList(_context.Domicilios, "Id", "Calle", cliente.DomicilioId);
            ViewData["TipoDocumentoId"] = new SelectList(_context.TiposDocumento, "Id", "Codigo", cliente.TipoDocumentoId);
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .Include(c => c.Domicilio)
                .Include(c => c.TipoDocumento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
