using GestionComercial.Web.Models.Entidades;

namespace GestionComercial.Web.Repositorios
{
	public interface IProductoRepositorio
	{
		// CRUD 
		public void Crear(Producto producto);

        public List<Producto> ObtenerTodos();

        public Producto ObtenerPorId(int id);

		public void Actualizar(Producto producto);

		public void Eliminar(int id);
	}
}
