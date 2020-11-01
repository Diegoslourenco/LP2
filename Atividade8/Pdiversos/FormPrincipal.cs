using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pdiversos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void formulário1ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void formulário2ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void formulário3ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void formulário4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 4 ja esta na memoria
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

        private void formulário5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 5 ja esta na memoria
            Form formulario = Application.OpenForms["frm5"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frm5 Frm5 = new frm5();
            Frm5.MdiParent = this; // Define em qual form ele ficará preso
            Frm5.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            Frm5.Show();
        }

        private void formulário6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 6 ja esta na memoria
            Form formulario = Application.OpenForms["frm6"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frm6 Frm6 = new frm6();
            Frm6.MdiParent = this; // Define em qual form ele ficará preso
            Frm6.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            Frm6.Show();
        }

        private void formulário7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 7 ja esta na memoria
            Form formulario = Application.OpenForms["frm7"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frm7 Frm7 = new frm7();
            Frm7.MdiParent = this; // Define em qual form ele ficará preso
            Frm7.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            Frm7.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
