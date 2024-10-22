using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionComercial.Data.Entidades;

public partial class Provincia
{
    public int Id { get; set; }

    [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo Descripción debe estar entre 3 y 50 caracteres")]
    public string Nombre { get; set; } = null!;

    [Display(Name = "País")]
    public int PaisId { get; set; }

    public virtual ICollection<Localidad> Localidades { get; set; } = new List<Localidad>();

    public virtual Paises Pais { get; set; } = null!;
}
