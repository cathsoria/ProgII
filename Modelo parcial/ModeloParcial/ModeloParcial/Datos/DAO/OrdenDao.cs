using ModeloParcial.Datos.Interfaces;
using ModeloParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial.Datos.DAO
{
    internal class OrdenDao : IOrdenDao
    {
        public List<Material> ObtenerMaterial()
        {
            List<Material> materiales = new List<Material>();
            materiales = HelperDao.Consultar

            return materiales;
        }

    }
}
