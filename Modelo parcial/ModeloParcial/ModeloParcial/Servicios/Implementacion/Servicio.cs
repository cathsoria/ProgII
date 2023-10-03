using ModeloParcial.Datos.DAO;
using ModeloParcial.Datos.Interfaces;
using ModeloParcial.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial.Servicios.Implementacion
{
    internal class Servicio : IServicio
    {
        public IOrdenDao dao;
        public Servicio()
        {
            dao = new OrdenDao();
        }

        public 

    }
}
