using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Data.Entidades;

public partial class Pedido
{
    public int Id { get; set; }

    [Display(Name = "Fecha Pedido")]
    public DateOnly FechaPedido { get; set; }

    [Display(Name = "Número")]
    public int Numero { get; set; }

    [Display(Name = "Cliente")]
    public int ClienteId { get; set; }

    [Display(Name = "Vendedor")]
    public int VendedorId { get; set; }

    public int DomicilioIdEntrega { get; set; }

    [Display(Name = "Fecha Entrega")]
    public DateOnly? FechaEntrega { get; set; }

    [Display(Name = "Fecha Envío")]
    public DateOnly? FechaEnvio { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallesPedidos { get; set; } = new List<DetallePedido>();

    public virtual Domicilio DomicilioIdEntregaNavigation { get; set; } = null!;

    public virtual Vendedor Vendedor { get; set; } = null!;
}
