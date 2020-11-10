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

namespace RecebeVetores
{
    public partial class frmVetores : Form
    {
        public frmVetores()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int maximoNumero = 10;
            double[] vetorA = new double[maximoNumero];
            double[] matrizB = new double[maximoNumero];
            String textoVetorA = "";
            String textoMatrizB = "";

            while (i < maximoNumero)
            {
                if (Double.TryParse(Interaction.InputBox($"Digite o valor {i + 1} do vetor: ", "Vetor A"),
                    out double numero))
                {
                    vetorA[i] = numero;
                    textoVetorA += $"{vetorA[i]} ";

                    if (i % 2 == 0)
                    {
                        matrizB[i] = numero * 5;
                        textoMatrizB += $"{matrizB[i]} ";
                    }
                    else
                    {
                        matrizB[i] = numero + 5;
                        textoMatrizB += $"{matrizB[i]} ";
                    }

                    i += 1;
                }
                else
                {
                    MessageBox.Show("Digite um número válido!");
                }
            }

            lstbxSaidas.Items.Add("Vetor A: ");
            lstbxSaidas.Items.Add(textoVetorA);
            lstbxSaidas.Items.Add("Matriz B: ");
            lstbxSaidas.Items.Add(textoMatrizB);
        }
    }
}
