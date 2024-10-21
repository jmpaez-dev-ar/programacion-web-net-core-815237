using System;
using System.Collections.Generic;

namespace GestionComercial.Data.Entidades;

public partial class Cliente
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? RazonSocial { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string? Telefono { get; set; }

    public string? Celular { get; set; }

    public string Email { get; set; } = null!;

    public int? TipoDocumentoId { get; set; }

    public int? NumeroDocumento { get; set; }

    public string? CuitCuil { get; set; }

    public int DomicilioId { get; set; }

    public virtual Domicilio Domicilio { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual TipoDocumento? TipoDocumento { get; set; }
}
