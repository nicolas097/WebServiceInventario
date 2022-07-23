using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaConexion
{
    public class Conexion
    {
        static private string CadenaConexion = "Data Source=DESKTOP-LP8ITU4;Initial Catalog=Inventario;Integrated Security=True";
        private SqlConnection conn = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;
        }


        public SqlConnection cerrarConexion()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return conn;
        }
    }
}
