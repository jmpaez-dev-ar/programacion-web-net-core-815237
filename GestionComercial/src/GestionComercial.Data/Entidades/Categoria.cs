using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Data.Entidades;

public partial class Categoria
{
    public int Id { get; set; }

    [Display(Name = "Código")]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
    public string Codigo { get; set; } = null!;

    [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
    public string Nombre { get; set; } = null!;


    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
