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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void btnSalario_Click(object sender, EventArgs e)
        {
            Double B = 0;
            Double C = 0;
            Double D = 0;
            Double salarioBruto = 0;
            Double salarioMaximo = 7000.00;
            
            if ((Double.TryParse(txtProducao.Text, out Double producao)) &&
                (Double.TryParse(txtSalario.Text, out Double salario))   &&
                (Double.TryParse(txtGratificacao.Text, out Double gratificacao)))
            {
                if (producao >= 150)
                {
                    B = 1.0;
                    C = 1.0;
                    D = 1.0;
                }
                else if (producao >= 120)
                {
                    B = 1.0; 
                    C = 1.0;
                }
                else if (producao >= 100)
                {
                    B = 1.0;
                }

                salarioBruto = salario + (salario * (0.05 * B + 0.10 * C + 0.01 * D)) + gratificacao;

                if ((salarioBruto > salarioMaximo) && ((producao < 150) || (gratificacao == 0)))
                {
                    salarioBruto = salarioMaximo;
                }

                txtSalarioBruto.Text = $"R$ {salarioBruto:N2}";
            }  
            else
            {
                MessageBox.Show("Digite um valor válido para produção!");
            }
        }
    }
}
