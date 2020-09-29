using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // entradas
            mskbxNomeFuncionario.Clear();
            mskbxSalarioBruto.Clear();
            mskbxNumeroFilhos.Clear();

            // saidas
            txtAliquotaINSS.Clear();
            txtAliquotaIRPF.Clear();
            txtDescontoINSS.Clear();
            txtDescontoIRPF.Clear();
            txtSalarioFamilia.Clear();
            txtSalarioLiquido.Clear();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Definindo variáveis
            string estadoCivil, filhos;
            string nomeFuncionario;
            byte numeroFilhos;
            double salarioBruto, salarioFamilia, salarioLiquido;
            double aliquotaINSS, aliquotaIRPF;
            double descontoINSS, descontoIRPF;

            // Testando se o nome do funcionario tem apenas texto
            for (var i = 0; i < mskbxNomeFuncionario.Text.Length; i++)
            {
                if ((Char.IsLetter(mskbxNomeFuncionario.Text[i]) == false) && 
                    (Char.IsWhiteSpace(mskbxNomeFuncionario.Text[i]) == false))
                {
                    MessageBox.Show("Digite apenas letras no campo Nome do Funcionário!");
                    return;
                }
            }

            // Testando se os campos nao estao vazios
            if (mskbxNumeroFilhos.Text == "" || mskbxSalarioBruto.Text == "" || mskbxNomeFuncionario.Text == "")
            {
                MessageBox.Show("Digite em todos os campos!");
                return;
            }

            // Convertendo valores
            numeroFilhos = Convert.ToByte(mskbxNumeroFilhos.Text);
            salarioBruto = Convert.ToDouble(mskbxSalarioBruto.Text) / 100;
            nomeFuncionario = mskbxNomeFuncionario.Text;

            // Definindo string filhos conforme numero de filhos informados
            if (numeroFilhos == 0)
            {
                filhos = "sem filhos";
            }
            else if (numeroFilhos == 1)
            {
                filhos = "com 1 filho";
            }
            else
            {
                filhos = $"com {numeroFilhos} filhos";
            }

            // Construindo texto do label dados
            if (rbtnFeminino.Checked)
            {
                if (ckbxCasado.Checked)
                {
                    estadoCivil = "casada";
                }
                else
                {
                    estadoCivil = "solteira";
                }

                lblDados.Text = $"Os descontos do salário da Sra. {nomeFuncionario}, " +
                                $"{estadoCivil} e {filhos} são:";
            }
            else
            {
                if (ckbxCasado.Checked)
                {
                    estadoCivil = "casado";
                }
                else
                {
                    estadoCivil = "solteiro";
                }

                lblDados.Text = $"Os descontos do salário do Sr. {nomeFuncionario}, " +
                                $"{estadoCivil} e {filhos} são:";
            }

            // Verificacao de faixa de INSS
            if (salarioBruto <= 800.47)
            {
                aliquotaINSS = 0.0765;
            }
            else if ((800.48 <= salarioBruto) && (salarioBruto <= 1050))
            {
                aliquotaINSS = 0.0865;
            }
            else if ((1050.01 <= salarioBruto) && (salarioBruto <= 1400.77))
            {
                aliquotaINSS = 0.09;
            }
            else if ((1400.78 <= salarioBruto) && (salarioBruto <= 2801.56))
            {
                aliquotaINSS = 0.11;
            }
            else
            {
                aliquotaINSS = 0.11;
            }

            // Verificacao de faixa de IRPF
            if (salarioBruto <= 1257.12)
            {
                aliquotaIRPF = 0;
            }
            else if ((1257.13 <= salarioBruto) && (salarioBruto <= 2512.08))
            {
                aliquotaIRPF = 0.15;
            }
            else
            {
                aliquotaIRPF = 0.275;
            }

            // Verificacao de salario familia
            if (salarioBruto <= 435.52)
            {
                salarioFamilia = 22.23 * numeroFilhos;
            }
            else if ((435.53 <= salarioBruto) && (salarioBruto <= 654.61))
            {
                salarioFamilia = 15.74 * numeroFilhos;
            }
            else
            {
                salarioFamilia = 0;
            }

            // Cálculo dos descontos
            descontoIRPF = salarioBruto * aliquotaIRPF;
            descontoINSS = salarioBruto * aliquotaINSS;

            // Cálculo de salário líquido
            salarioLiquido = salarioBruto + salarioFamilia - descontoINSS - descontoIRPF;

            // Passando para a tela
            txtAliquotaINSS.Text =      $"{aliquotaINSS * 100:N2}%";
            txtAliquotaIRPF.Text =      $"{aliquotaIRPF * 100:N2}%";
            txtDescontoINSS.Text =      $"R$ {descontoINSS:N2}";
            txtDescontoIRPF.Text =      $"R$ {descontoIRPF:N2}";
            txtSalarioFamilia.Text =    $"R$ {salarioFamilia:N2}";
            txtSalarioLiquido.Text =    $"R$ {salarioLiquido:N2}";
        }
    }
}
