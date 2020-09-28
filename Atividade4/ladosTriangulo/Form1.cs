using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ladosTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtA.Focus();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Definindo variáveis
            double ladoA, ladoB, ladoC;

            // Verificando se os campos estão vazios
            if ((txtA.Text == "") || (txtB.Text == "") || (txtC.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Verificando se os campos estão preenchidos
            if(double.TryParse(txtA.Text, out ladoA) && double.TryParse(txtB.Text, out ladoB) && double.TryParse(txtC.Text, out ladoC))
            {
                if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
                {
                    MessageBox.Show("Insira valores maiores que zero!");
                    return;
                }

                // Verificando a regra de triangulos
                if (ladoA < Math.Abs(ladoB - ladoC) || ladoA > ladoB + ladoC)
                {
                    MessageBox.Show("Lado A não passa na regra!");
                    return;
                }
                else if (ladoB < Math.Abs(ladoA - ladoC) || ladoB > ladoA + ladoC)
                {
                    MessageBox.Show("Lado B não passa na regra!");
                    return;
                }
                else if (ladoC < Math.Abs(ladoA - ladoB) || ladoC > ladoA + ladoB)
                {
                    MessageBox.Show("Lado C não passa na regra!");
                    return;
                }

                // Conferindo o tipo de triangulo
                if (ladoA == ladoB && ladoA == ladoC)
                {
                    MessageBox.Show("O triângulo é equilátero!");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    MessageBox.Show("O triângulo é isósceles!");
                }
                else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
                {
                    MessageBox.Show("O triângulo é escaleno!");
                }     
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
