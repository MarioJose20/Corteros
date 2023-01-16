using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Corteros
{
    class Procedimientos
    {
        public Conexion conexion = new Conexion();
        public SqlCommand comando = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public SqlConnection sc = new SqlConnection();


        public void InsertarEmpleado(string dni, string nombreEmpleado, string apellidoEmpleado, string celular,
        string direccion, DateTime fechaNacimiento, DateTime fechaIngreso, string ciudad, string departamento,
        string pais, string estadoCivil)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "[dbo].[Empleados]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEmpleado", "");
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
                comando.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
                comando.Parameters.AddWithValue("@celular", celular);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                comando.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                comando.Parameters.AddWithValue("@ciudad", ciudad);
                comando.Parameters.AddWithValue("@departamento", departamento);
                comando.Parameters.AddWithValue("@pais", pais);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                comando.Parameters.AddWithValue("@accion", "Insertar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }

        public void ActualizarEmpleado(int idEmpleado, string dni, string nombreEmpleado, string apellidoEmpleado, string celular,
        string direccion, DateTime fechaNacimiento, DateTime fechaIngreso, string ciudad, string departamento,
        string pais, string estadoCivil)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "[dbo].[Empleados]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
                comando.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
                comando.Parameters.AddWithValue("@celular", celular);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                comando.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                comando.Parameters.AddWithValue("@ciudad", ciudad);
                comando.Parameters.AddWithValue("@departamento", departamento);
                comando.Parameters.AddWithValue("@pais", pais);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                comando.Parameters.AddWithValue("@accion", "Actualizar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void ActualizarEstadoEmpleado(int idEmpleado)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                //comando = new SqlCommand("update [dbo].[Empleado] set estado = 'Inactivo' where idEmpleado = " + idEmpleado, conexion.conexion);

                comando.CommandText = "ActualizarEstado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }

        public DataTable ListarEmpleados()
        {
            SqlDataAdapter da = new SqlDataAdapter("[dbo].[MostrarEmpleados]", conexion.Abrir());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Cerrar();
            return dt;
        }
        public void InsertarFrente(string codFrente, string nombreFrente)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "[dbo].[Frentes]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idFrente", "");
                comando.Parameters.AddWithValue("@codFrente", codFrente);
                comando.Parameters.AddWithValue("@nombreFrente", nombreFrente);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@accion", "Insertar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void ActualizarFrente(int idFrente, string codFrente, string nombreFrente)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "[dbo].[Frentes]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idFrente", idFrente);
                comando.Parameters.AddWithValue("@codFrente", codFrente);
                comando.Parameters.AddWithValue("@nombreFrente", nombreFrente);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@accion", "Actualizar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public DataTable ListarFrente()
        {
            SqlDataAdapter da = new SqlDataAdapter("[dbo].[MostrarFrente]", conexion.Abrir());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Cerrar();
            return dt;
        }
        public void ActualizarEstadoFrente(int idFrente)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                //comando = new SqlCommand("update [dbo].[Empleado] set estado = 'Inactivo' where idEmpleado = " + idEmpleado, conexion.conexion);

                comando.CommandText = "ActualizarEstadoFrente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idFrente", idFrente);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void InsertarTipoFinca(string nombreTipoFinca)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "[dbo].[TipoFincas]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idTipoFinca", "");
                comando.Parameters.AddWithValue("@nombreTipoFinca", nombreTipoFinca);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@accion", "Insertar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void ActualizarTipoFinca(int idTipoFinca, string nombreTipoFinca)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "[dbo].[TipoFincas]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idTipoFinca", idTipoFinca);
                comando.Parameters.AddWithValue("@nombreTipoFinca", nombreTipoFinca);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@accion", "Actualizar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public DataTable ListarTipoFinca()
        {
            SqlDataAdapter da = new SqlDataAdapter("[dbo].[MostrarTipoFinca]", conexion.Abrir());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Cerrar();
            return dt;
        }
        public void ActualizarEstadoTipoFinca(int idTipoFinca)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                //comando = new SqlCommand("update [dbo].[Empleado] set estado = 'Inactivo' where idEmpleado = " + idEmpleado, conexion.conexion);

                comando.CommandText = "[dbo].[ActualizarEstadoTipoFinca]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idTipoFinca", idTipoFinca);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void InsertarDistrito(string nombreDistrito)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "[dbo].[Distritos]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idDistrito", "");
                comando.Parameters.AddWithValue("@nombreDistrito", nombreDistrito);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@accion", "Insertar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void ActualizarDistrito(int idDistrito, string nombreDistrito)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "[dbo].[Distritos]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idDistrito", idDistrito);
                comando.Parameters.AddWithValue("@nombreDistrito", nombreDistrito);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@accion", "Actualizar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public DataTable ListarDistrito()
        {
            SqlDataAdapter da = new SqlDataAdapter("[dbo].[MostrarDistrito]", conexion.Abrir());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Cerrar();
            return dt;
        }
        public void ActualizarEstadoDistrito(int idDistrito)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                //comando = new SqlCommand("update [dbo].[Empleado] set estado = 'Inactivo' where idEmpleado = " + idEmpleado, conexion.conexion);

                comando.CommandText = "[dbo].[ActualizarEstadoDistrito]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idDistrito", idDistrito);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public DataTable ComboDistrito()
        {
            SqlDataAdapter da = new SqlDataAdapter("ListarDistrito", conexion.Abrir());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            DataRow fila = dataTable.NewRow();
            fila["nombreDistrito"] = "Seleccione";
            dataTable.Rows.InsertAt(fila, 0);
            conexion.Cerrar();
            return dataTable;

        }
        public DataTable ComboTipoFinca()
        {
            SqlDataAdapter da = new SqlDataAdapter("ListarTipoFinca", conexion.Abrir());
            comando.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow fila = dt.NewRow();
            fila["nombreTipoFinca"] = "Seleccione";
            dt.Rows.InsertAt(fila, 0);
            conexion.Cerrar();
            return dt;
        }
        public void InsertarFinca(string nombreFinca, int idDistrito, int idTipoFinca)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "sp_Finca";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idFinca", "");
                comando.Parameters.AddWithValue("@nombreFinca", nombreFinca);
                comando.Parameters.AddWithValue("@idDistrito", idDistrito);
                comando.Parameters.AddWithValue("@idTipoFinca", idTipoFinca);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@accion", "Insertar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void ActualizarFinca(int idFinca, string nombreFinca, int idDistrito, int idTipoFinca)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "sp_Finca";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idFinca", idFinca);
                comando.Parameters.AddWithValue("@nombreFinca", nombreFinca);
                comando.Parameters.AddWithValue("@idDistrito", idDistrito);
                comando.Parameters.AddWithValue("@idTipoFinca", idTipoFinca);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@accion", "Actualizar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void ActualizarEstadoFinca(int idFinca)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "sp_Finca";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idFinca", idFinca);
                comando.Parameters.AddWithValue("@nombreFinca", "");
                comando.Parameters.AddWithValue("@idDistrito", "");
                comando.Parameters.AddWithValue("@idTipoFinca", "");
                comando.Parameters.AddWithValue("@estado", "Inactivo");
                comando.Parameters.AddWithValue("@accion", "ActualizarEst");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public DataTable ListarFinca()
        {
            SqlDataAdapter da = new SqlDataAdapter("MostrarFinca", conexion.Abrir());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Cerrar();
            return dt;
        }
        public void Buscar(DataGridView dgv, string Query)
        {
            try
            {
                da = new SqlDataAdapter(Query, comando.Connection = conexion.Abrir());
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha sido posible establecer conexion" + ex.ToString()); ;
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void InsertarSupervisor(string dni, int idFrente, string nombreSupervisor, string apellidoSupervisor, DateTime fechaIngreso, 
        string celular, string direccion, string ciudad, string departamento,string pais)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "sp_Supervisores";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idSupervisor", "");
                comando.Parameters.AddWithValue("@DNI", dni);
                comando.Parameters.AddWithValue("@idFrente", idFrente);
                comando.Parameters.AddWithValue("@nombreSupervisor", nombreSupervisor);
                comando.Parameters.AddWithValue("@apellidoSupervisor", apellidoSupervisor);
                comando.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                comando.Parameters.AddWithValue("@celularSupervisor", celular);
                comando.Parameters.AddWithValue("@direccionSupervisor", direccion);
                comando.Parameters.AddWithValue("@ciudad", ciudad);
                comando.Parameters.AddWithValue("@departamento", departamento);
                comando.Parameters.AddWithValue("@pais", pais);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@accion", "Insertar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void ActualizarSupervisor(int idSupervisor, string dni, int idFrente, string nombreSupervisor, string apellidoSupervisor, DateTime fechaIngreso,
        string celular, string direccion, string ciudad, string departamento, string pais)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "sp_Supervisores";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idSupervisor", idSupervisor);
                comando.Parameters.AddWithValue("@DNI", dni);
                comando.Parameters.AddWithValue("@idFrente", idFrente);
                comando.Parameters.AddWithValue("@nombreSupervisor", nombreSupervisor);
                comando.Parameters.AddWithValue("@apellidoSupervisor", apellidoSupervisor);
                comando.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                comando.Parameters.AddWithValue("@celularSupervisor", celular);
                comando.Parameters.AddWithValue("@direccionSupervisor", direccion);
                comando.Parameters.AddWithValue("@ciudad", ciudad);
                comando.Parameters.AddWithValue("@departamento", departamento);
                comando.Parameters.AddWithValue("@pais", pais);
                comando.Parameters.AddWithValue("@estado", "Activo");
                comando.Parameters.AddWithValue("@accion", "Actualizar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void ActualizarEstadoSupervisor(int idSupervisor)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "sp_Supervisores";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idSupervisor", idSupervisor);
                comando.Parameters.AddWithValue("@DNI", "");
                comando.Parameters.AddWithValue("@idFrente", "");
                comando.Parameters.AddWithValue("@nombreSupervisor", "");
                comando.Parameters.AddWithValue("@apellidoSupervisor", "");
                comando.Parameters.AddWithValue("@fechaIngreso", "");
                comando.Parameters.AddWithValue("@celularSupervisor", "");
                comando.Parameters.AddWithValue("@direccionSupervisor", "");
                comando.Parameters.AddWithValue("@ciudad", "");
                comando.Parameters.AddWithValue("@departamento", "");
                comando.Parameters.AddWithValue("@pais", "");
                comando.Parameters.AddWithValue("@estado", "Inactivo");
                comando.Parameters.AddWithValue("@accion", "ActualizarEst");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public DataTable ListarSupervisor()
        {
            SqlDataAdapter da = new SqlDataAdapter("MostrarSupervisor", conexion.Abrir());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Cerrar();
            return dt;
        }
        public DataTable ComboFrente()
        {
            SqlDataAdapter da = new SqlDataAdapter("MostrarFrente", conexion.Abrir());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            DataRow fila = dataTable.NewRow();
            fila["Frente"] = "Seleccione";
            dataTable.Rows.InsertAt(fila, 0);
            conexion.Cerrar();
            return dataTable;

        }
        public void InsertarDistancia(string nombreDistanciaSiembra, float mlineales)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "sp_DistanciaSiembra";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idDistanciaSiembra", "");
                comando.Parameters.AddWithValue("@nombreDistanciaSiembra", nombreDistanciaSiembra);
                comando.Parameters.AddWithValue("@mLineales", mlineales);
                comando.Parameters.AddWithValue("@accion", "Insertar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public void ActualizarDistancia(int idDistanciaSiembra, string nombreDistanciaSiembra, float mlineales)
        {
            try
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "sp_DistanciaSiembra";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idDistanciaSiembra", idDistanciaSiembra);
                comando.Parameters.AddWithValue("@nombreDistanciaSiembra", nombreDistanciaSiembra);
                comando.Parameters.AddWithValue("@mLineales", mlineales);
                comando.Parameters.AddWithValue("@accion", "Actualizar");
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                comando.Connection = conexion.Cerrar();
            }
        }
        public DataTable ListarDistancia()
        {
            SqlDataAdapter da = new SqlDataAdapter("MostrarDistancia", conexion.Abrir());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Cerrar();
            return dt;
        }
    }
}