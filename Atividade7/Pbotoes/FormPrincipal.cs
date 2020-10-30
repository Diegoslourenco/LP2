using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pbotoes
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 1 ja esta na memoria
            Form formulario = Application.OpenForms["frm1"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frm1 Frm1 = new frm1();
            Frm1.MdiParent = this; // Define em qual form ele ficará preso
            Frm1.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            Frm1.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 2 ja esta na memoria
            Form formulario = Application.OpenForms["frm2"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frm2 Frm2 = new frm2();
            Frm2.MdiParent = this; // Define em qual form ele ficará preso
            Frm2.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            Frm2.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 3 ja esta na memoria
            Form formulario = Application.OpenForms["frm3"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frm3 Frm3 = new frm3();
            Frm3.MdiParent = this; // Define em qual form ele ficará preso
            Frm3.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            Frm3.Show();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 1 ja esta na memoria
            Form formulario = Application.OpenForms["frm4"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frm4 Frm4 = new frm4();
            Frm4.MdiParent = this; // Define em qual form ele ficará preso
            Frm4.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            Frm4.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
