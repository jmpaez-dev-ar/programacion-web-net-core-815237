using System;
using System.Collections.Generic;

namespace GestionComercial.Data.Entidades;

public partial class Vendedor
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public DateOnly? FechaContratacion { get; set; }

    public string? Telefono { get; set; }

    public string? Celular { get; set; }

    public string? Email { get; set; }

    public int? TipoDocumentoId { get; set; }

    public int? NumeroDocumento { get; set; }

    public int DomicilioId { get; set; }

    public virtual Domicilio Domicilio { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual TipoDocumento? TipoDocumento { get; set; }
}
