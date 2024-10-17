using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Web.Models.Entidades
{
	public class Producto
	{
        public int Id { get; set; }

		[Display(Name = "Detalle")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
		public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}
