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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContaNumero_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (int i = 0; i < rchtxtText.Text.Length; i++)
            {
                if (char.IsNumber(rchtxtText.Text[i]))
                {
                    contador += 1;
                }
            }

            MessageBox.Show($"Quantidade de números: {contador}!");
        }

        private void btnPosicao_Click(object sender, EventArgs e)
        {
            int i = 0;

            while(i < rchtxtText.Text.Length)
            {
                if (Char.IsWhiteSpace(rchtxtText.Text[i]) == true)
                {

                    MessageBox.Show($"Caracter branco na posição {i}!");
                    return;
                }

                i++;
            }

            MessageBox.Show("Não exite nenhum caracter em branco!");
        }

        private void btnContaLetra_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char letra in rchtxtText.Text)
            {
                if (Char.IsLetter(letra))
                {
                    contador++;
                }
            }

            MessageBox.Show($"Quantidade de letras: {contador}!");
        }
    }
}
