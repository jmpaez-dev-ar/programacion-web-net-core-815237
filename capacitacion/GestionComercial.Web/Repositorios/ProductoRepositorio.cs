using GestionComercial.Web.Models.Entidades;
using System.Data.SqlClient;

namespace GestionComercial.Web.Repositorios
{
	public class ProductoRepositorio : IProductoRepositorio
	{
		private readonly string _connectionString;

		public ProductoRepositorio()
		{
			_connectionString = @"Data Source=.\sqlexpress;Initial Catalog=GestionComercial;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True";
		}

        public List<Producto> ObtenerTodos()
		{
			var productos = new List<Producto>();
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "SELECT Id, Nombre, Precio FROM Productos";
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							productos.Add(new Producto
							{
								Id = reader.GetInt32(0),
								Nombre = reader.GetString(1),
								Precio = reader.GetDecimal(2)
							});
						}
					}
				}
			}
			return productos;
		}

        public Producto ObtenerPorId(int id)
		{
			var producto = new Producto();
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "SELECT Id, Nombre, Precio FROM Productos WHERE Id = @id";
					command.Parameters.AddWithValue("@id", id);
					using (var reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							producto.Id = reader.GetInt32(0);
							producto.Nombre = reader.GetString(1);
							producto.Precio = reader.GetDecimal(2);
						}
					}
				}
			}
			return producto;
		}

        public void Crear(Producto producto)
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "INSERT INTO Productos (Nombre, Precio) VALUES (@nombre, @precio)";
					command.Parameters.AddWithValue("@nombre", producto.Nombre);
					command.Parameters.AddWithValue("@precio", producto.Precio);
					command.ExecuteNonQuery();
				}
			}
		}

        public void Actualizar(Producto producto)
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "UPDATE Productos SET Nombre = @nombre, Precio = @precio WHERE Id = @id";
					command.Parameters.AddWithValue("@nombre", producto.Nombre);
					command.Parameters.AddWithValue("@precio", producto.Precio);
					command.Parameters.AddWithValue("@id", producto.Id);
					command.ExecuteNonQuery();
				}
			}
		}


        public void Eliminar(int id)
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "DELETE FROM Productos WHERE Id = @id";
					command.Parameters.AddWithValue("@id", id);
					command.ExecuteNonQuery();
				}
			}
		}
	}
}
