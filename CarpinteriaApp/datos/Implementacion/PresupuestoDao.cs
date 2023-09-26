using CarpinteriaApp.datos.Interfaz;
using CarpinteriaApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.datos.Implementacion
{
    internal class PresupuestoDao : IPresupuestoDao
    {
        public bool Crear(Presupuesto oPresupuesto)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> lProductos = new List<Producto>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_PRODUCTO");
            foreach (DataRow fila in tabla.Rows)
            {
                int nro = int.Parse(fila["id_producto"].ToString());
                string nom = fila["n_producto"].ToString();
                double pre = double.Parse(fila["precio"].ToString());
                bool activo = fila["activo"].ToString().Equals("S");
                Producto p = new Producto(nro, nom, pre);
                p.Activo = activo;
                lProductos.Add(p);
            }   

            return lProductos;
        }

        public int ObtenerProximoPresupuesto()
        {
            return HelperDao.ObtenerInstancia().ConsultarEscalar("SP_PROXIMO_ID","@next");
        }
    }
}
