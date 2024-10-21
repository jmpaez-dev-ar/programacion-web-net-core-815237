using System;
using System.Collections.Generic;

namespace GestionComercial.Data.Entidades;

public partial class Paises
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Provincia> Provincia { get; set; } = new List<Provincia>();
}
