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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            double altura, peso, pesoIdeal;
            char genero;

            //Verificando se os campos não estão vazios
            if (rbtnFeminino.Checked == false && rbtnMasculino.Checked == false)
            {
                MessageBox.Show("Selecione Feminino ou Masculino!");
                return;
            }
            else if ((mskbxAltura.Text == "") || (mskbxPeso.Text == ""))
            {
                MessageBox.Show("Digite os valores!");
                return;     
            }

            //Definindo o genero
            if (rbtnFeminino.Checked)
            {
                genero = 'F';
            }
            else
            {
                genero = 'M';
            }

            // Validando valores e calculando resultado conforme sexo
            if (double.TryParse(mskbxAltura.Text, out altura) && double.TryParse(mskbxPeso.Text, out peso))
            {
                if (genero == 'F')
                {
                    pesoIdeal = Math.Round(((62.1 * altura) - 44.7), 2);
                }
                else
                {
                    pesoIdeal = Math.Round((72.7 * altura) - 58, 2);
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
                    MessageBox.Show("Coma bastante massas e doces!");
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxAltura.Clear();
            mskbxPeso.Clear();
            mskbxAltura.Focus();
        }

        private void mskbxAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
