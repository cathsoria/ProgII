using ModeloParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial.Datos.Interfaces
{
    internal interface IOrdenDao
    {
        List<Material> ObtenerMateriales();


    }
}
