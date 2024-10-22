using GestionComercial.Data.Data;
using GestionComercial.Data.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace GestionComercial.Data.Repositorios
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        private readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;
        private readonly ILogger<RepositorioGenerico<T>> _logger;

        public RepositorioGenerico(GestionComercialDbContext context, ILogger<RepositorioGenerico<T>> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<T>> ObtenerTodosAsync(bool sinSeguimiento = true)
        {
            try
            {
                var query = _dbSet.AsQueryable();
                if (sinSeguimiento)
                {
                    query = query.AsNoTracking();
                }
                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener todos los registros: {ex.Message}");
                throw;
            }
        }

        public async Task<T?> ObtenerPorIdAsync(int id, bool sinSeguimiento = true)
        {
            try
            {
                var query = _dbSet.AsQueryable();
                if (sinSeguimiento)
                {
                    query = query.AsNoTracking();
                }
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener el registro por ID: {ex.Message}");
                throw;
            }
        }

        public async Task<List<T>> ObtenerPorCondicionAsync(Expression<Func<T, bool>> expresion, bool sinSeguimiento = true)
        {
            try
            {
                var query = _dbSet.Where(expresion);
                if (sinSeguimiento)
                {
                    query = query.AsNoTracking();
                }
                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener registros por condición: {ex.Message}");
                throw;
            }
        }

        public async Task CrearAsync(T entidad)
        {
            try
            {
                if (entidad == null) throw new ArgumentNullException(nameof(entidad));

                await _dbSet.AddAsync(entidad);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo registro: {ex.Message}");
                throw;
            }
        }

        public async Task ActualizarAsync(T entidad)
        {
            try
            {
                if (entidad == null) throw new ArgumentNullException(nameof(entidad));

                _dbSet.Update(entidad);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al actualizar el registro: {ex.Message}");
                throw;
            }
        }

        public async Task EliminarAsync(T entidad)
        {
            try
            {
                if (entidad == null) throw new ArgumentNullException(nameof(entidad));

                _dbSet.Remove(entidad);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al eliminar el registro: {ex.Message}");
                throw;
            }
        }

        public async Task<List<T>> ObtenerPaginadoAsync(int numeroPagina, int tamañoPagina, bool sinSeguimiento = true)
        {
            try
            {
                var query = _dbSet.AsQueryable();
                if (sinSeguimiento)
                {
                    query = query.AsNoTracking();
                }
                return await query.Skip((numeroPagina - 1) * tamañoPagina).Take(tamañoPagina).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener registros paginados: {ex.Message}");
                throw;
            }
        }
    }
}

