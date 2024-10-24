using GestionComercial.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComercial.Data.Repositorios.Interfaces
{
    public interface ICategoriaRepositorio : IRepositorioGenerico<Categoria>
    {
        Task<List<Categoria>> ObtenerCategoriasConProductosAsync(bool sinSeguimiento = true);
    }
}
