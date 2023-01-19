using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corteros
{
    public partial class FrmEmpleado : Form
    {
        Procedimientos procedimientos = new Procedimientos();
        Validaciones validaciones = new Validaciones();
        public FrmEmpleado()
        {
            InitializeComponent();
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        string id;
        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar();
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             try
             {
                DialogResult r = MessageBox.Show("¿Desea guardar el empleado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtApellido.Text != string.Empty && txtNombre.Text != string.Empty && txtCelular.Text != string.Empty && txtDireccion.Text != string.Empty && txtDni.Text != string.Empty && txtCiudad.Text != string.Empty)
                    {
                        if (dtFechaNacimiento.Value.Date.AddYears(18) <= DateTime.Today)
                        {
                            if (dtFechaIngreso.Value.Date >= DateTime.Today)
                            {
                                if (cmbDepartamento.Text != "Seleccione" && cmbEstadoCivil.Text != "Seleccione" && cmbPais.Text != "Seleccione")
                                {
                                    if (txtApellido.Text != " ")
                                    {
                                        procedimientos.InsertarEmpleado(txtDni.Text, txtNombre.Text, txtApellido.Text, txtCelular.Text, txtDireccion.Text,
                                        dtFechaNacimiento.Value.Date, dtFechaIngreso.Value.Date, txtCiudad.Text, cmbDepartamento.Text, cmbPais.Text,
                                        cmbEstadoCivil.Text);
                                        MessageBox.Show("Empleado guardado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Mostrar();
                                        Limpiar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese el apellido");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Seleccione correctamente el departamento, el país y el estado cívil", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese correctamente la fecha de ingreso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El empleado tiene que ser mayor de edad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese correctamente los datos en las cajas de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
             }
             catch (Exception ex)
             {
                MessageBox.Show("Error al agregar el empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Mostrar()
        {
            dgListado.DataSource = procedimientos.ListarEmpleados();
            btnActualizar.Enabled = false;
        }
        public void Limpiar()
        {
            txtDni.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            dtFechaNacimiento.Value = DateTime.Today;
            dtFechaIngreso.Value = DateTime.Today;
            txtCiudad.Text = string.Empty;
            cmbDepartamento.SelectedIndex = 0;
            cmbPais.SelectedIndex = 0;
            cmbEstadoCivil.SelectedIndex = 0;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
            btnActualizarEstado.Enabled = false;
        }

        private void dgListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDni.Text = dgListado.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgListado.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = dgListado.CurrentRow.Cells[3].Value.ToString();
            txtCelular.Text = dgListado.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgListado.CurrentRow.Cells[5].Value.ToString();
            dtFechaNacimiento.Text = dgListado.CurrentRow.Cells[6].Value.ToString();
            dtFechaIngreso.Text = dgListado.CurrentRow.Cells[7].Value.ToString();
            txtCiudad.Text = dgListado.CurrentRow.Cells[8].Value.ToString();
            cmbDepartamento.Text = dgListado.CurrentRow.Cells[9].Value.ToString();
            cmbPais.Text = dgListado.CurrentRow.Cells[10].Value.ToString();
            cmbEstadoCivil.Text = dgListado.CurrentRow.Cells[11].Value.ToString();
            id = dgListado.CurrentRow.Cells[0].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnActualizarEstado.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea actualizar el empleado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtApellido.Text != string.Empty && txtNombre.Text != string.Empty && txtCelular.Text != string.Empty && txtDireccion.Text != string.Empty && txtDni.Text != string.Empty && txtCiudad.Text != string.Empty)
                    {
                        if(dtFechaNacimiento.Value.Date.AddYears(18) <= DateTime.Today)
                        {
                            
                                if (cmbDepartamento.Text != "Seleccione" && cmbEstadoCivil.Text != "Seleccione" && cmbPais.Text != "Seleccione")
                                {
                                    procedimientos.ActualizarEmpleado(int.Parse(id), txtDni.Text, txtNombre.Text, txtApellido.Text, txtCelular.Text, txtDireccion.Text,
                                    dtFechaNacimiento.Value.Date, dtFechaIngreso.Value.Date, txtCiudad.Text, cmbDepartamento.Text, cmbPais.Text,
                                    cmbEstadoCivil.Text);
                                    MessageBox.Show("Empleado actualizado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Mostrar();
                                    Limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Seleccione correctamente el departamento, el país y el estado cívil", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                        }
                        else
                        {
                           MessageBox.Show("El empleado tiene que ser mayor de edad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese correctamente los datos en las cajas de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado, revise su dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea inactivar el empleado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    procedimientos.ActualizarEstadoEmpleado(int.Parse(id));
                    MessageBox.Show("Empleado inactivado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                    Limpiar();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Seleccione un empleado para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
           
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetras(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            procedimientos.Buscar(dgListado, "Select e.idEmpleado [ID], e.dni [DNI], e.nombreEmpleado [Nombres], " +
                "e.apellidoEmpleado [Apellidos], e.celular [Celular], e.direccion [Dirección], e.fechaNacimiento [Fecha de nacimiento], " +
                "e.fechaIngreso [Fecha de ingreso], e.ciudad [Ciudad], e.departamento [Departamento], e.pais [País], e.estadoCivil [Estado cívil], " +
                "e.estado [Estado] from Empleado as e where estado = 'Activo' and nombreEmpleado like '%" + txtBuscar.Text + "%'");

        }
        private void txtCiudad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetras(e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
