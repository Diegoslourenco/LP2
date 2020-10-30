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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemover1_Click(object sender, EventArgs e)
        {
            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);


            while (posicao >= 0)
            {
                int comprimentoPalavra1 = txtPalavra1.Text.Length;
                int comprimentoPalavra2 = txtPalavra2.Text.Length;

                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) + txtPalavra2.Text.Substring(posicao + comprimentoPalavra1, comprimentoPalavra2 - comprimentoPalavra1 - posicao);
                
                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnRemover2_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            char[] auxiliar = txtPalavra1.Text.ToCharArray();

            Array.Reverse(auxiliar);

            foreach (char caracter in auxiliar)
            {
                txtPalavra2.Text += caracter;
            }
        }
    }
}
