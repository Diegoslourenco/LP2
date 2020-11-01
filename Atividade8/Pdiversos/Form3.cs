using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pdiversos
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void btnFaturamento_Click(object sender, EventArgs e)
        {
            int maximo = 10;
            int[] quantidades = new int[maximo];
            double[] precos = new double[maximo];
            double faturamento = 0;
            int i = 0;
            int j = 0;

            while (i < maximo)
            {
                if (int.TryParse((Interaction.InputBox($"Digite a quantidade do produto {i + 1}:", "Quantidades de Mercadoria")),
                    out quantidades[i]))
                {
                    i += 1;
                }
                else
                {
                    MessageBox.Show("Digite um valor inteiro!");
                    continue;
                }
            }

            while (j < maximo)
            {
                if (double.TryParse((Interaction.InputBox($"Digite o preço do produto {j + 1}:", "Preços de Mercadoria")),
                    out precos[j]))
                {
                    j += 1;
                }
                else
                {
                    MessageBox.Show("Digite um preço válido!");
                    continue;
                }
            }

            for (i = 0; i < maximo; i++)
            {
                faturamento += quantidades[i] * precos[i];
            }

            MessageBox.Show($"O valor do faturamento mensal é de R$ {faturamento:N2}");
        }
    }
}
