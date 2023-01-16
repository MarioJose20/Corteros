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
    public partial class FrmSupervisor : Form
    {
        Procedimientos procedimientos = new Procedimientos();
        Validaciones validaciones = new Validaciones();
        public FrmSupervisor()
        {
            InitializeComponent();
            cmbFrente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void ListarFrente()
        {
            cmbFrente.DataSource = procedimientos.ComboFrente();
            cmbFrente.DisplayMember = "Frente";
            cmbFrente.ValueMember = "Id";
        }
        private void FrmSupervisor_Load(object sender, EventArgs e)
        {
            ListarFrente();
            Limpiar();
            Mostrar();
        }
        public void Mostrar()
        {
            dgvListado.DataSource = procedimientos.ListarSupervisor();
            btnActualizar.Enabled = false;
        }
        public void Limpiar()
        {
            ListarFrente();
            txtDni.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            cmbFrente.SelectedIndex = 0;
            cmbDepartamento.SelectedIndex = 0;
            cmbPais.SelectedIndex = 0;
            dtFechaIngreso.Value = DateTime.Today;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
            btnActualizarEstado.Enabled = false;
        }
        string id;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea guardar el supervisor?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtApellido.Text != string.Empty && txtNombre.Text != string.Empty && txtCelular.Text != string.Empty && txtDireccion.Text != string.Empty && txtDni.Text != string.Empty && txtCiudad.Text != string.Empty)
                    {
                        if (dtFechaIngreso.Value.Date >= DateTime.Today)
                        {
                            if (cmbDepartamento.Text != "Seleccione" && cmbFrente.Text != "Seleccione" && cmbPais.Text != "Seleccione")
                            {
                                procedimientos.InsertarSupervisor(txtDni.Text, Convert.ToInt32(cmbFrente.SelectedValue), txtNombre.Text, txtApellido.Text, dtFechaIngreso.Value.Date, txtCelular.Text, txtDireccion.Text,
                                txtCiudad.Text, cmbDepartamento.Text, cmbPais.Text);
                                MessageBox.Show("Supervisor guardado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Mostrar();
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Seleccione correctamente el departamento, el país y el frente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese correctamente la fecha de ingreso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Error al agregar el supervisor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea actualizar el supervisor?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtApellido.Text != string.Empty && txtNombre.Text != string.Empty && txtCelular.Text != string.Empty && txtDireccion.Text != string.Empty && txtDni.Text != string.Empty && txtCiudad.Text != string.Empty)
                    {
                        if (cmbDepartamento.Text != "Seleccione" && cmbFrente.Text != "Seleccione" && cmbPais.Text != "Seleccione")
                        {
                            procedimientos.ActualizarSupervisor(int.Parse(id), txtDni.Text, Convert.ToInt32(cmbFrente.SelectedValue), txtNombre.Text, txtApellido.Text, dtFechaIngreso.Value.Date, txtCelular.Text, txtDireccion.Text,
                            txtCiudad.Text, cmbDepartamento.Text, cmbPais.Text);
                            MessageBox.Show("Supervisor actualizado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Mostrar();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione correctamente el departamento, el país y el frente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Error al actualizar el supervisor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDni.Text = dgvListado.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvListado.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = dgvListado.CurrentRow.Cells[3].Value.ToString();
            dtFechaIngreso.Text = dgvListado.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = dgvListado.CurrentRow.Cells[5].Value.ToString();
            txtDireccion.Text = dgvListado.CurrentRow.Cells[6].Value.ToString();
            txtCiudad.Text = dgvListado.CurrentRow.Cells[7].Value.ToString();
            cmbDepartamento.Text = dgvListado.CurrentRow.Cells[8].Value.ToString();
            cmbPais.Text = dgvListado.CurrentRow.Cells[9].Value.ToString();
            cmbFrente.Text = dgvListado.CurrentRow.Cells[10].Value.ToString();
            id = dgvListado.CurrentRow.Cells[0].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnActualizarEstado.Enabled = true;
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea inactivar el supervisor?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    procedimientos.ActualizarEstadoSupervisor(int.Parse(id));
                    MessageBox.Show("Supervisor inactivado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un supervisor para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            procedimientos.Buscar(dgvListado, "select s.idSupervisor [Id], s.DNI [Dni], s.nombreSupervisor [Nombres]," +
                " s.apellidoSupervisor [Apellidos], s.fechaIngreso [Fecha de ingreso], s.celularSupervisor [Celular], " +
                "s.direccionSupervisor [Dirección], s.ciudad [Ciudad], s.departamento [Departamento], s.pais [País], " +
                "f.nombreFrente [Frente], s.estado [Estado] from Supervisor s inner join Frente f on s.idFrente = f.idFrente " +
                "where s.estado = 'Activo' and DNI like '%" + txtBuscar.Text +  "%'");
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
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
    }
}
