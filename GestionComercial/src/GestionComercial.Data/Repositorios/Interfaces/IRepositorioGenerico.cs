using System.Linq.Expressions;

namespace GestionComercial.Data.Repositorios.Interfaces
{
    public interface IRepositorioGenerico<T> where T : class
    {
        // CRUD 

        // Crear
        Task CrearAsync(T entidad);

        // Consultas
        Task<List<T>> ObtenerTodosAsync(bool sinSeguimiento = true);
        Task<T?> ObtenerPorIdAsync(int id, bool sinSeguimiento = true);
        Task<List<T>> ObtenerPorCondicionAsync(Expression<Func<T, bool>> expresion, bool sinSeguimiento = true);
        Task<List<T>> ObtenerPaginadoAsync(int numeroPagina, int tamañoPagina, bool sinSeguimiento = true);

        // Actualizar
        Task ActualizarAsync(T entidad);

        // Eliminar
        Task EliminarAsync(T entidad);
    }
}
