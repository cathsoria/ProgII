using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial.Datos
{
    internal class DBHelper
    {
        SqlConnection conexion;
        public DBHelper()
        {
            conexion = new SqlConnection("Data Source=DESKTOP-18UAML7;Initial Catalog=db_ordenes;Integrated Security=True");
        }

        public DataTable Consultar(string nombreSP)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            return tabla;
        }

    }
}
