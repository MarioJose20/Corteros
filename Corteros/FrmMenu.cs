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
    public partial class FrmMenu : Form
    {
        FrmFinca Finca = new FrmFinca();
        FrmEmpleado Empleados = new FrmEmpleado();
        frmDistrito Distrito = new frmDistrito();
        FrmSupervisor Super = new FrmSupervisor();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();

            r = MessageBox.Show("Seguro que desea salir del sistema?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finca.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleados.ShowDialog();
        }

        private void btnDistrito_Click(object sender, EventArgs e)
        {
            this.Hide();
            Distrito.ShowDialog();
        }

        private void btnSupervisores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Super.ShowDialog();
        }
    }
}
