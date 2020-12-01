using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PF_0030482011037
{
    public partial class frmPrincipal : Form
    {

        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // Abre a conexao com o servidor
                conexao = new SqlConnection(
                    "Data Source=LAPTOP-6JKVG7D8\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True"
                );
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de Banco de daods =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/"+ ex.Message);
            }
        }

        private void cadastroCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade frmCidade = new frmCidade();
            frmCidade.MdiParent = this;
            frmCidade.WindowState = FormWindowState.Maximized;
            frmCidade.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox frmS = new AboutBox();
            frmS.MdiParent = this;
            frmS.WindowState = FormWindowState.Maximized;
            frmS.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form fc = Application.OpenForms["frmCidade"];

            if (fc != null)
            {
                fc.Close();
            }

            frmCidade drmC = new frmCidade();
        }
    }
}
