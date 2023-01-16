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
        static private string cadena = "Data Source = MARIOJOSE;Initial Catalog=Corteros; Integrated Security=True";
        private SqlConnection conexion = new SqlConnection(cadena);

        public SqlConnection Abrir()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
                //MessageBox.Show("Felicidades conexion abierta", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
