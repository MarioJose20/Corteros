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
    public partial class FrmDistanciaSiembra : Form
    {
        Procedimientos procedimientos = new Procedimientos();
        Validaciones validaciones = new Validaciones();
        public FrmDistanciaSiembra()
        {
            InitializeComponent();
        }
        string id;
        private void FrmDistanciaSiembra_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void Mostrar()
        {
            dgvDistancia.DataSource = procedimientos.ListarDistancia();
            btnActualizar.Enabled = false; btnActualizar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea guardar la distancia?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtDistancia.Text != string.Empty && txtMetrosL.Text != string.Empty)
                    {
                        procedimientos.InsertarDistancia(txtDistancia.Text, float.Parse(txtMetrosL.Text));
                        MessageBox.Show("Distancia guardada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error al agregar la distancia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea actualizar la distancia?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtDistancia.Text != string.Empty && txtMetrosL.Text != string.Empty)
                    {
                        procedimientos.ActualizarDistancia(int.Parse(id), txtDistancia.Text, float.Parse(txtMetrosL.Text));
                        MessageBox.Show("Distancia actualizada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error al actualizar la distancia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Limpiar()
        {
            txtDistancia.Text = string.Empty;
            txtMetrosL.Text = string.Empty;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
            btnActualizarEstado.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            procedimientos.Buscar(dgvDistancia, "select idDistanciaSiembra [Id], nombreDistanciaSiembra [Distancia], mLineales [Metros líneales] from DistanciaSiembra where nombreDistanciaSiembra like '%" + txtBuscar.Text + "%'");
        }

        private void dgvDistancia_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtDistancia.Text = dgvDistancia.CurrentRow.Cells[1].Value.ToString();
            txtMetrosL.Text = dgvDistancia.CurrentRow.Cells[2].Value.ToString();
            id = dgvDistancia.CurrentRow.Cells[0].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnActualizarEstado.Enabled = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
