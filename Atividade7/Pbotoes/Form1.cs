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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnEspacos_Click(object sender, EventArgs e)
        {
            int espacos = 0;

            for (int i = 0; i < rchtxtTexto.Text.Length; i++)
            {
                if (rchtxtTexto.Text[i] == ' ')
                {
                    espacos += 1;
                }
            }

            MessageBox.Show($"Número de Espaços em Branco: {espacos}");
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int letraR = 0;

            foreach (char letra in rchtxtTexto.Text)
            {
                if (letra == 'R')
                {
                    letraR += 1;
                }
            }

            MessageBox.Show($"Número de Letras R: {letraR}");
        }

        private void btnLetraRepetida_Click(object sender, EventArgs e)
        {
            int letraRepetida = 0;

            for (int i = 0; i < rchtxtTexto.Text.Length - 1; i++)
            {
                if (rchtxtTexto.Text[i] == rchtxtTexto.Text[i + 1])
                {
                    letraRepetida += 1;
                }
            }

            MessageBox.Show($"Número de Letras Repetidas: {letraRepetida}");
        }
    }
}
