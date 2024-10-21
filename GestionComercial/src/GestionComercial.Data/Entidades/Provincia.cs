using System;
using System.Collections.Generic;

namespace GestionComercial.Data.Entidades;

public partial class Provincia
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int PaisId { get; set; }

    public virtual ICollection<Localidad> Localidades { get; set; } = new List<Localidad>();

    public virtual Paises Pais { get; set; } = null!;
}
