using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Data.Entidades;

public partial class Localidad
{
    public int Id { get; set; }

    [StringLength(100, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
    public string Nombre { get; set; } = null!;

    [Display(Name = "Provincia")]
    public int ProvinciaId { get; set; }

    public virtual ICollection<Domicilio> Domicilios { get; set; } = new List<Domicilio>();

    public virtual Provincia Provincia { get; set; } = null!;
}
