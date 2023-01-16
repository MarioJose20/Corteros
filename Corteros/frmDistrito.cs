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
    public partial class frmDistrito : Form
    {
        Procedimientos procedimientos = new Procedimientos();
        Validaciones validaciones = new Validaciones();
        public frmDistrito()
        {
            InitializeComponent();
        }
        string id;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea guardar el distrito?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtDistrito.Text != string.Empty)
                    {
                        procedimientos.InsertarDistrito(txtDistrito.Text);
                        MessageBox.Show("Distrito guardado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el distrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el distrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Mostrar()
        {
            dgvDistrito.DataSource = procedimientos.ListarDistrito();
            btnActualizar.Enabled = false; btnActualizar.Enabled = false;
        }
        private void Limpiar()
        {
            txtDistrito.Text = string.Empty;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
            btnActualizarEstado.Enabled = false;
        }
        private void dgvDistrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDistrito.Text = dgvDistrito.CurrentRow.Cells[1].Value.ToString();
            id = dgvDistrito.CurrentRow.Cells[0].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnActualizarEstado.Enabled = true;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea actualizar el distrito?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtDistrito.Text != string.Empty)
                    {
                        procedimientos.ActualizarDistrito(int.Parse(id), txtDistrito.Text);
                        MessageBox.Show("Distrito actualizado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el distrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un distrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea inactivar el distrito?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    procedimientos.ActualizarEstadoDistrito(int.Parse(id));
                    MessageBox.Show("El distrito se ha inactivado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un distrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void frmDistrito_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void txtBuscarDistrito_TextChanged(object sender, EventArgs e)
        {
            procedimientos.Buscar(dgvDistrito, "select d.idDistrito [ID], d.nombreDistrito [Distrito], d.estado [Estado] from Distrito d where d.estado = 'Activo' and nombreDistrito like '%" + txtBuscarDistrito.Text + "%'");
        }
    }
}
