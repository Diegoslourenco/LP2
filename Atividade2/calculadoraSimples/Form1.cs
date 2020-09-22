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
        double numero1, numero2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpando dados
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
            txtNumero1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //saindo da aplicacao
            Close();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            //soma de dois numeros

            //Verificando validade dos dados
            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 + numero2;

                txtResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }        
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            //Subtracao de dois numeros

            //Verificando validade dos dados
            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 - numero2;

                txtResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            //Multiplicacao de dois numeros

            //Verificando validade dos dados
            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 * numero2;

                txtResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            //Divisao de dois numeros

            //Verificando validade dos dados
            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNumero2.Text, out numero2)))
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("Denominador não pode ser zero!");
                }
                else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString("N2");
                }
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13) // transforma o 13 em caracter, é o enter
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; // desativando som de beep
            }
        }
    }
}
