using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;

namespace Corteros
{
    internal class Conexion
    {
        static private string cadena = "Data Source=LAPTOP-H2UB6CQP\\SQLEXPRESS;Initial Catalog=Corteros;Integrated Security=True";
        private SqlConnection conexion = new SqlConnection(cadena);

        public SqlConnection Abrir()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection Cerrar()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }

    }
}
