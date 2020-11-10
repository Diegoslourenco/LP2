using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36.SomaValores
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            String mensagemErro = "Digite um número inteiro positivo entre 0 e 50!" +
                                  "\nDigite um valor novamente!";

            if (Int32.TryParse(txtNumero.Text, out Int32 numeroEntrada))
            {
                if ((numeroEntrada > 0) && (numeroEntrada < 50))
                {
                    double numeroSaida = 0;

                    for (double i = 0; i < numeroEntrada; i++)
                    {
                        numeroSaida += (i + 1) / (i + 2);
                    }

                    MessageBox.Show($"Valor da soma é: {numeroSaida:N2}");
                }
                else
                {
                    MessageBox.Show(mensagemErro);
                }
            }
            else
            {
                MessageBox.Show(mensagemErro);
            }

            txtNumero.Text = "";
            txtNumero.Focus();
        }
    }
}
