using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.datos
{
    internal class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection cnn;

        private HelperDao()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString);
        }

        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDao();
            return instancia;
        }

        public int ConsultarEscalar(string nombreSP,string nombreParamOut)
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = nombreSP;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = nombreParamOut;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();

            cnn.Close();
            return (int)pOut.Value;

        }
    }
}
