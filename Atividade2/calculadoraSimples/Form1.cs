using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            //limpando dados
            textNumero1.Clear();
            textNumero2.Clear();
            textResultado.Clear();
            textNumero1.Focus();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            //saindo da aplicacao
            Close();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            //soma de dois numeros

            double numero1, numero2, resultado;

            //Verificando validade dos dados
            if (double.TryParse(textNumero1.Text, out numero1) && double.TryParse(textNumero2.Text, out numero2))
            {
                resultado = numero1 + numero2;

                textResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }        
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            //Subtracao de dois numeros

            double numero1, numero2, resultado;

            //Verificando validade dos dados
            if (double.TryParse(textNumero1.Text, out numero1) && double.TryParse(textNumero2.Text, out numero2))
            {
                resultado = numero1 - numero2;

                textResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            //Multiplicacao de dois numeros

            double numero1, numero2, resultado;

            //Verificando validade dos dados
            if (double.TryParse(textNumero1.Text, out numero1) && double.TryParse(textNumero2.Text, out numero2))
            {
                resultado = numero1 * numero2;

                textResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            //Divisao de dois numeros

            double numero1, numero2, resultado;

            //Verificando validade dos dados
            if (double.TryParse(textNumero1.Text, out numero1) && double.TryParse(textNumero2.Text, out numero2))
            {
                resultado = numero1 / numero2;

                textResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void textNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13) // transforma o 13 em caracter, é o enter
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; // desativando som de beep
            }
        }
    }
}
