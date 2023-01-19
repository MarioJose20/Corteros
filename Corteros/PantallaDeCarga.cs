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
    public partial class PantallaDeCarga : Form
    {
        public PantallaDeCarga()
        {
            InitializeComponent();
        }

        private void Carga_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;

            if (panel2.Width >= 641)
            {
                Carga.Stop();
                this.Hide();
                FrmMenu Menu = new FrmMenu();
                Menu.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
