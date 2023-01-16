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
    public partial class FrmFrente : Form
    {
        Procedimientos procedimientos = new Procedimientos();
        Validaciones validaciones = new Validaciones();
        public FrmFrente()
        {
            InitializeComponent();
        }
        string id;
        private void FrmFrente_Load(object sender, EventArgs e)
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
                    if(txtCodigoFrente.Text != string.Empty && txtNombreFrente.Text != string.Empty)
                    {
                        procedimientos.InsertarFrente(txtCodigoFrente.Text, txtNombreFrente.Text);
                        MessageBox.Show("Frente guardado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese correctamente los datos en las cajas de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el frente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea guardar el empleado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if(txtCodigoFrente.Text != string.Empty && txtNombreFrente.Text != string.Empty)
                    {
                        procedimientos.ActualizarFrente(int.Parse(id), txtCodigoFrente.Text, txtNombreFrente.Text);
                        MessageBox.Show("Frente actualizado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese correctamente los datos en las cajas de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un frente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Mostrar()
        {
            dgvFrente.DataSource = procedimientos.ListarFrente();
            btnActualizar.Enabled = false; btnActualizar.Enabled = false;
        }

        private void dgvFrente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoFrente.Text = dgvFrente.CurrentRow.Cells[1].Value.ToString();
            txtNombreFrente.Text = dgvFrente.CurrentRow.Cells[2].Value.ToString();
            id = dgvFrente.CurrentRow.Cells[0].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnActualizarEstado.Enabled = true;
        }
        private void Limpiar()
        {
            txtCodigoFrente.Text = string.Empty;
            txtNombreFrente.Text = string.Empty;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
            btnActualizarEstado.Enabled = false;
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
                    procedimientos.ActualizarEstadoFrente(int.Parse(id));
                    MessageBox.Show("Frente inactivado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un frente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscarFrente_TextChanged(object sender, EventArgs e)
        {
            procedimientos.Buscar(dgvFrente, "select f.idFrente [ID], f.codFrente [Código frente], f.nombreFrente [Nombre frente], f.estado [Estado] from Frente as f where f.estado = 'Activo' and codFrente like '%" + txtBuscarFrente.Text + "%'");
        }
    }
}
