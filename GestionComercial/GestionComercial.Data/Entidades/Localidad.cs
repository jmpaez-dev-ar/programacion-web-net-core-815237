using System;
using System.Collections.Generic;

namespace GestionComercial.Data.Entidades;

public partial class Localidad
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int ProvinciaId { get; set; }

    public virtual ICollection<Domicilio> Domicilios { get; set; } = new List<Domicilio>();

    public virtual Provincia Provincia { get; set; } = null!;
}
