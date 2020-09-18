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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textA.Clear();
            textB.Clear();
            textC.Clear();
            textA.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Definindo variáveis
            double ladoA, ladoB, ladoC;

            // Verificando se os campos estão vazios
            if (textA.Text == "")
            {
                MessageBox.Show("Preencha o campo A!");
                return;
            }
            else if (textB.Text == "")
            {
                MessageBox.Show("Preencha o campo B!");
                return;
            }
            else if (textC.Text == "")
            {
                MessageBox.Show("Preencha o campo C!");
                return;
            }

            // Verificando se os campos estão preenchidos
            if(double.TryParse(textA.Text, out ladoA) && double.TryParse(textB.Text, out ladoB) && double.TryParse(textC.Text, out ladoC))
            {
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

        private void textA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
