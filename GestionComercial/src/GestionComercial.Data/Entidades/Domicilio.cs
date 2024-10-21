using System;
using System.Collections.Generic;

namespace GestionComercial.Data.Entidades;

public partial class Domicilio
{
    public int Id { get; set; }

    public string Calle { get; set; } = null!;

    public int Altura { get; set; }

    public string? Piso { get; set; }

    public string? Departamento { get; set; }

    public string? Barrio { get; set; }

    public string? EntreCalles { get; set; }

    public string? CodigoPostal { get; set; }

    public int? LocalidadId { get; set; }

    public string? Observacion { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Localidad? Localidad { get; set; }

    public virtual Pedido? Pedido { get; set; }

    public virtual Vendedor? Vendedore { get; set; }
}
