using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesoIdeal
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            double altura, peso, pesoIdeal;
            String sexo;

            //Verificando se os campos não estão vazios
            if (radioButtonFeminino.Checked == false && radioButtonMasculino.Checked == false)
            {
                MessageBox.Show("Selecione Feminino ou Masculino!");
                return;
            }

            //Definindo sexo
            if (radioButtonFeminino.Checked)
            {
                sexo = "Feminino";
            }
            else
            {
                sexo = "Masculino";
            }

            // Validando valores e calculando resultado conforme sexo
            if (double.TryParse(maskedTextBoxAltura.Text, out altura) && double.TryParse(maskedTextBoxPeso.Text, out peso))
            {
                if (sexo == "Feminino")
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                }
                else
                {
                    pesoIdeal = (72.7 * altura) - 58;
                }

                if (pesoIdeal == peso)
                {
                    MessageBox.Show("Você está com o peso ideal!");
                }
                else if (pesoIdeal < peso)
                {
                    MessageBox.Show("Regine Obrigatório Já!");
                }
                else
                {
                    MessageBox.Show("Coma bastante massa e doces!");
                }
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            maskedTextBoxAltura.Clear();
            maskedTextBoxPeso.Clear();
            maskedTextBoxAltura.Focus();
        }

        private void maskedTextBoxAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
