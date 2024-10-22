using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Data.Entidades;

public partial class Domicilio
{
    public int Id { get; set; }

    [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
    public string Calle { get; set; } = null!;

    public int Altura { get; set; }

    public string? Piso { get; set; }

    public string? Departamento { get; set; }

    public string? Barrio { get; set; }

    [Display(Name = "Entre Calles")]
    public string? EntreCalles { get; set; }

    [Display(Name = "Código Postal")]
    public string? CodigoPostal { get; set; }

    [Display(Name = "Localidad")]
    public int? LocalidadId { get; set; }

    [Display(Name = "Observación")]
    [DataType(DataType.MultilineText)]
    public string? Observacion { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Localidad? Localidad { get; set; }

    public virtual Pedido? Pedido { get; set; }

    public virtual Vendedor? Vendedor { get; set; }
}
