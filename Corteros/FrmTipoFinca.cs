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
    public partial class FrmTipoFinca : Form
    {
        Procedimientos procedimientos = new Procedimientos();
        Validaciones validaciones = new Validaciones();
        public FrmTipoFinca()
        {
            InitializeComponent();
        }
        string id;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea guardar el tipo de finca?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtTipoFinca.Text != string.Empty)
                    {
                        procedimientos.InsertarTipoFinca(txtTipoFinca.Text);
                        MessageBox.Show("Tipo de finca guardado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el tipo de finca.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el tipo de finca.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Mostrar()
        {
            dgvTipoFinca.DataSource = procedimientos.ListarTipoFinca();
            btnActualizar.Enabled = false; btnActualizar.Enabled = false;
        }
        private void Limpiar()
        {
            txtTipoFinca.Text = string.Empty;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
            btnActualizarEstado.Enabled = false;
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea inactivar el tipode finca?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    procedimientos.ActualizarEstadoTipoFinca(int.Parse(id));
                    MessageBox.Show("El tipo de finca se ha inactivado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un tipo de finca.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmTipoFinca_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void dgvTipoFinca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipoFinca.Text = dgvTipoFinca.CurrentRow.Cells[1].Value.ToString();
            id = dgvTipoFinca.CurrentRow.Cells[0].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnActualizarEstado.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea actualizar el tipo de finca?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtTipoFinca.Text != string.Empty)
                    {
                        procedimientos.ActualizarTipoFinca(int.Parse(id), txtTipoFinca.Text);
                        MessageBox.Show("Tipo de finca actualizado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el tipo de finca.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un tipo de finca.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtBuscarTipoFinca_TextChanged(object sender, EventArgs e)
        {
            procedimientos.Buscar(dgvTipoFinca, "select t.idTipoFinca [ID], t.nombreTipoFinca [Tipo de finca], t.estado [Estado] from TipoFinca t where t.estado = 'Activo' and nombreTipoFinca like '%" + txtBuscarTipoFinca.Text + "%'");

        }
    }
}
