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

        public RepositorioGenerico(GestionComercialDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
        }

        public async Task<List<T>> ObtenerTodosAsync(bool sinSeguimiento = true)
        {
            var query = _dbSet.AsQueryable();
            if (sinSeguimiento)
            {
                query = query.AsNoTracking();
            }
            return await query.ToListAsync();
        }

        public async Task<T?> ObtenerPorIdAsync(int id, bool sinSeguimiento = true)
        {
            var query = _dbSet.AsQueryable();
            if (sinSeguimiento)
            {
                query = query.AsNoTracking();
            }
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<T>> ObtenerPorCondicionAsync(Expression<Func<T, bool>> expresion, bool sinSeguimiento = true)
        {
            var query = _dbSet.Where(expresion);
            if (sinSeguimiento)
            {
                query = query.AsNoTracking();
            }
            return await query.ToListAsync();
        }

        public async Task CrearAsync(T entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            await _dbSet.AddAsync(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(T entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            _dbSet.Update(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(T entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            _dbSet.Remove(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> ObtenerPaginadoAsync(int numeroPagina, int tamañoPagina, bool sinSeguimiento = true)
        {
            var query = _dbSet.AsQueryable();
            if (sinSeguimiento)
            {
                query = query.AsNoTracking();
            }
            return await query.Skip((numeroPagina - 1) * tamañoPagina).Take(tamañoPagina).ToListAsync();
        }
    }
}

