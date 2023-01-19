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
    public partial class FrmFinca : Form
    {        
        Procedimientos procedimientos = new Procedimientos();
        public FrmFinca()
        {
            InitializeComponent();
            cmbDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoFinca.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void ListarDistrito()
        {
            cmbDistrito.DataSource = procedimientos.ComboDistrito();
            cmbDistrito.DisplayMember = "nombreDistrito";
            cmbDistrito.ValueMember = "idDistrito";
        }
        public void ListarTipoFinca()
        {
            cmbTipoFinca.DataSource = procedimientos.ComboTipoFinca();
            cmbTipoFinca.DisplayMember = "nombreTipoFinca";
            cmbTipoFinca.ValueMember = "idTipoFinca";
        }
        private void FrmFinca_Load(object sender, EventArgs e)
        {
            Mostrar();
            ListarTipoFinca();
            ListarDistrito();
        }
        string id;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea guardar la finca?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtNombreFinca.Text != string.Empty && cmbDistrito.Text != "Seleccione" && cmbTipoFinca.Text != "Seleccione")
                    {
                        procedimientos.InsertarFinca(txtNombreFinca.Text, Convert.ToInt32(cmbDistrito.SelectedValue), Convert.ToInt32(cmbTipoFinca.SelectedValue));
                        MessageBox.Show("Finca guardada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error al agregar la finca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Limpiar()
        {
            txtNombreFinca.Text = string.Empty;
            ListarTipoFinca();
            ListarDistrito();
            btnActualizar.Enabled = false;
            btnActualizarEstado.Enabled = false;
            btnAgregar.Enabled = true;

            txtTipoFinca.Text = string.Empty;
            btnActualizar2.Enabled = false;
            btnAgregar2.Enabled = true;
            btnActualizarEstado2.Enabled = false;

        }
        private void Mostrar()
        {
            dgvFinca.DataSource = procedimientos.ListarFinca();
            btnActualizar.Enabled = false; btnActualizar.Enabled = false;

            dgvTipoFinca.DataSource = procedimientos.ListarTipoFinca();
            btnActualizar2.Enabled = false; 
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvFinca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreFinca.Text = dgvFinca.CurrentRow.Cells[1].Value.ToString();
                cmbDistrito.Text = dgvFinca.CurrentRow.Cells[2].Value.ToString();
                cmbTipoFinca.Text = dgvFinca.CurrentRow.Cells[3].Value.ToString();
                id = dgvFinca.CurrentRow.Cells[0].Value.ToString();
                btnAgregar.Enabled = false;
                btnActualizar.Enabled = true;
                btnActualizarEstado.Enabled = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea actualizar la finca?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (txtNombreFinca.Text != string.Empty && cmbDistrito.Text != "Seleccione" && cmbTipoFinca.Text != "Seleccione")
                    {
                        procedimientos.ActualizarFinca(int.Parse(id), txtNombreFinca.Text, Convert.ToInt32(cmbDistrito.SelectedValue), Convert.ToInt32(cmbTipoFinca.SelectedValue));
                        MessageBox.Show("Finca actualizada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error al actualizar la finca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea inactivar la finca?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    procedimientos.ActualizarEstadoFinca(int.Parse(id));
                    MessageBox.Show("Finca inactivada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una finca.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscarFinca_TextChanged(object sender, EventArgs e)
        {
            procedimientos.Buscar(dgvFinca, "select f.idFinca [ID], f.nombreFinca [Finca], d.nombreDistrito [Distrito], t.nombreTipoFinca [Tipo de finca] from Finca as f inner join Distrito as d on f.idDistrito = d.idDistrito inner join TipoFinca as t on f.idTipoFinca = t.idTipoFinca where f.estado = 'Activo' and d.estado = 'Activo' and t.estado = 'Activo' and nombreFinca like '%" + txtBuscarFinca.Text + "%'");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            this.Hide();            
            menu.Show();
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
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

        private void btnActualizar2_Click(object sender, EventArgs e)
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

        private void btnActualizarEstado2_Click(object sender, EventArgs e)
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

        private void btnBorrar2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvTipoFinca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipoFinca.Text = dgvTipoFinca.CurrentRow.Cells[1].Value.ToString();
            id = dgvTipoFinca.CurrentRow.Cells[0].Value.ToString();
            btnAgregar2.Enabled = false;
            btnActualizar2.Enabled = true;
            btnActualizarEstado2.Enabled = true;
        }
    }
}
