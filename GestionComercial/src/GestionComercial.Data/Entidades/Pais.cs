using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Data.Entidades;

public partial class Pais
{
    public int Id { get; set; }

    [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
    public string Nombre { get; set; } = null!;

    public virtual ICollection<Provincia> Provincia { get; set; } = new List<Provincia>();
}
