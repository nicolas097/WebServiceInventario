using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaClases;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class NegocioSalidaProducto
    {
        private Conexion conn = new Conexion();
        private SqlCommand cmd = new SqlCommand();

        public bool Insertar(SalidaProducto sa)
        {

            DateTime fecha = DateTime.Now;

            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = $"INSERT INTO SALIDA_PRODUCTO VALUES ({sa.numSalida},'{fecha.ToString("yyyy-MM-dd HH:mm:ss")}','{sa.sku}',{sa.cantidad_salida})";

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {

                return false;
            }
        }


        public int traerStock(string sku)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = $"SELECT CANTIDAD FROM STOCK WHERE SKU = '{sku}'";
            int stock = Convert.ToInt32(cmd.ExecuteScalar());
            conn.cerrarConexion();
            return stock;
        }


        public int actualizarStock(string sku, int cantidad)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = $"UPDATE stock SET cantidad = cantidad - {cantidad} WHERE SKU = '{sku}'";
            cmd.ExecuteNonQuery();
            conn.cerrarConexion();
            return cantidad;
        }

    }
}
