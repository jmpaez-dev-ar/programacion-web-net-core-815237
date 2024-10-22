using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Data.Entidades;

public partial class DetallePedido
{
    public int Id { get; set; }

    public int PedidoId { get; set; }

    [Display(Name = "Producto")]
    public int ProductoId { get; set; }

    [Range(1, 9999, ErrorMessage = "La cantidad debe ser mayor a 0")]
    public int Cantidad { get; set; }

    [Display(Name = "Precio Unitario")]
    public decimal PrecioUnitario { get; set; }

    [Display(Name = "Descuento %")]
    public decimal DescuentoPorcentaje { get; set; }

    public virtual Pedido Pedido { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
