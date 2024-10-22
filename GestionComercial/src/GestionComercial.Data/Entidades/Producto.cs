using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Data.Entidades;

public partial class Producto 
{
    public int Id { get; set; }

    [Display(Name = "Código")]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
    public string Codigo { get; set; } = null!;

    [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
    public string Nombre { get; set; } = null!;

    [Display(Name = "Precio Unitario")]
    [DataType(DataType.Currency)]
    [Range(0, 99999999.99)]
    public decimal PrecioUnitario { get; set; }

    [Display(Name = "Categoría")]
    public int CategoriaId { get; set; }

    [Display(Name = "Unidades en Existencia")]
    public int? UnidadesEnExistencia { get; set; }

    [Display(Name = "Unidades en Pedido")]
    public int? UnidadesEnPedido { get; set; }

    [Display(Name = "Nivel de Reposición")]
    public int? NivelNuevoPedido { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallesPedido { get; set; } = new List<DetallePedido>();
}
