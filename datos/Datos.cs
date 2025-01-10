using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class Datos
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public Datos()
        {
            conn = new SqlConnection("server=.\\SQLEXPRESS; database=PROMOS_DB; integrated security=true");
            cmd = new SqlCommand();
        }

        public void SetearDatos(string query)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
        }

        public void EjecutarDatos()
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EjecutarAccionDatos()
        {
            cmd.Connection = conn;
            try
            {   
                conn.Open ();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SetearParametros(string nombre, object valor)
        {
            cmd.Parameters.AddWithValue(nombre, valor);
        }

        public void cerrarConexion()
        {
            if (reader != null)
            {
                reader.Close();
            }
            conn.Close();
        }
    }
}
