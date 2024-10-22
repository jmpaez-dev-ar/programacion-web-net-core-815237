using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Data.Entidades;

public partial class TipoDocumento
{
    public int Id { get; set; }

    [Display(Name = "Código")]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "La longitud del campo Código debe estar entre 3 y 15 caracteres")]
    public string Codigo { get; set; } = null!;

    [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo Descripción debe estar entre 3 y 50 caracteres")]
    public string Nombre { get; set; } = null!;


    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();
}
