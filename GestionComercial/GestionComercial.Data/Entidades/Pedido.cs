using System;
using System.Collections.Generic;

namespace GestionComercial.Data.Entidades;

public partial class Pedido
{
    public int Id { get; set; }

    public DateOnly FechaPedido { get; set; }

    public int Numero { get; set; }

    public int ClienteId { get; set; }

    public int VendedorId { get; set; }

    public int DomicilioIdEntrega { get; set; }

    public DateOnly? FechaEntrega { get; set; }

    public DateOnly? FechaEnvio { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallesPedidos { get; set; } = new List<DetallePedido>();

    public virtual Domicilio DomicilioIdEntregaNavigation { get; set; } = null!;

    public virtual Vendedor Vendedor { get; set; } = null!;
}
