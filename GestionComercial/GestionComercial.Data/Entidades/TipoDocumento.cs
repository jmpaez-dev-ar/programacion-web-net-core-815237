using System;
using System.Collections.Generic;

namespace GestionComercial.Data.Entidades;

public partial class TipoDocumento
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Vendedor> Vendedors { get; set; } = new List<Vendedor>();
}
