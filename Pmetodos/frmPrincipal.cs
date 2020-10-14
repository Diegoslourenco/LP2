using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmetodos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chamou copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chamou colar");
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 2 ja esta na memoria
            Form formulario = Application.OpenForms["frmExercicio2"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frmExercicio2 FrmExercicio2 = new frmExercicio2();
            FrmExercicio2.MdiParent = this; // Define em qual form ele ficará preso
            FrmExercicio2.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            FrmExercicio2.Show();

        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 3 ja esta na memoria
            Form formulario = Application.OpenForms["frmExercicio3"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frmExercicio3 FrmExercicio3 = new frmExercicio3();
            FrmExercicio3.MdiParent = this; // Define em qual form ele ficará preso
            FrmExercicio3.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            FrmExercicio3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 4 ja esta na memoria
            Form formulario = Application.OpenForms["frmExercicio4"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frmExercicio4 FrmExercicio4 = new frmExercicio4();
            FrmExercicio4.MdiParent = this; // Define em qual form ele ficará preso
            FrmExercicio4.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            FrmExercicio4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Testa se o formulario 5 ja esta na memoria
            Form formulario = Application.OpenForms["frmExercicio5"];

            if (formulario != null)
            {
                formulario.Close();
            }

            frmExercicio5 FrmExercicio5 = new frmExercicio5();
            FrmExercicio5.MdiParent = this; // Define em qual form ele ficará preso
            FrmExercicio5.WindowState = FormWindowState.Maximized; // Para abrir maximizado
            FrmExercicio5.Show();
        }
    }
}
