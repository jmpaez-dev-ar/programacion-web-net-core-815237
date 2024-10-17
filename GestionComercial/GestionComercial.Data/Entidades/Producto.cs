using System;
using System.Collections.Generic;

namespace GestionComercial.Data.Entidades;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal PrecioUnitario { get; set; }

    public int CategoriaId { get; set; }

    public int? UnidadesEnExistencia { get; set; }

    public int? UnidadesEnPedido { get; set; }

    public int? NivelNuevoPedido { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallesPedido { get; set; } = new List<DetallePedido>();
}
