using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Data.Entidades;

public partial class Cliente
{
    public int Id { get; set; }

    [Display(Name = "Código")]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
    public string Codigo { get; set; } = null!;

    [Display(Name = "Razón Social")]
    public string? RazonSocial { get; set; }

    [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
    public string Apellido { get; set; } = null!;

    [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
    public string Nombre { get; set; } = null!;

    [Display(Name = "Fecha Nacimiento")]
    public DateOnly FechaNacimiento { get; set; }

    [Display(Name = "Teléfono")]
    public string? Telefono { get; set; }

    public string? Celular { get; set; }

    [EmailAddress]
    public string Email { get; set; } = null!;

    [Display(Name = "Tipo Documento")]
    public int? TipoDocumentoId { get; set; }

    [Display(Name = "Nº Documento")]
    public int? NumeroDocumento { get; set; }

    [StringLength(13)]
    [Display(Name = "CUIT/CUIL")]
    [RegularExpression(@"^\d{2}-\d{8}-\d{1}$|^$", ErrorMessage = "El campo Cuit/Cuil debe tener el formato XX-XXXXXXXX-X o estar vacío")]
    public string? CuitCuil { get; set; }

    public int DomicilioId { get; set; }

    public virtual Domicilio Domicilio { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual TipoDocumento? TipoDocumento { get; set; }
}
