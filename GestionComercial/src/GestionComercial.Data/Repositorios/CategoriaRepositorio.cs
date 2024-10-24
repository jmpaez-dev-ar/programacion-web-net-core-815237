using GestionComercial.Data.Data;
using GestionComercial.Data.Entidades;
using GestionComercial.Data.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GestionComercial.Data.Repositorios
{
    public class CategoriaRepositorio : RepositorioGenerico<Categoria>, ICategoriaRepositorio
    {
        private readonly ILogger<CategoriaRepositorio> _logger;
        public CategoriaRepositorio(GestionComercialDbContext context, ILogger<CategoriaRepositorio> logger
            ) : base(context, logger)
        {
            _logger = logger;
        }

        public async Task<List<Categoria>> ObtenerCategoriasConProductosAsync(bool sinSeguimiento = true)
        {
            try
            {
                var query = _dbSet.Include(c => c.Productos).AsQueryable();
                if (sinSeguimiento)
                {
                    query = query.AsNoTracking();
                }
                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener las categorías con productos: {ex.Message}");
                throw;
            }
        }

    }
}
