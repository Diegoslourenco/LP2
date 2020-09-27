using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraCompleta
{
    public partial class Form1 : Form
    {
        double valorAtual = 0;
        double acumulado = 0;
        string operacaoAtual = "";
        string operacaoAnterior = "";
        string temp = "";
        bool primeiraOperacao = true;
        bool operacaoPressionada = false;
        bool operadorAtivo = false;
        bool igualPressionado = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Saindo da aplicacao
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Limpando dados e reiniciando
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            txtVisorFundo.Clear();
            acumulado = 0;
            valorAtual = 0;
            primeiraOperacao = true;
            operadorAtivo = false;
            txtVisorFundo.ScrollBars = ScrollBars.None;
        }

        // Apagando o ultimo digito
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length == 1)
            {
                txtVisor.Text = "0";
            }
            else
            {
                // remove ultimo char da string
                txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1, 1);
            }
        }

        // Concatenacao dos digitos e virgula
        private void btn_Click(object sender, EventArgs e)
        {
            if (igualPressionado == true)
            {
                btnLimpar.PerformClick();
                txtVisor.Text = "";
                igualPressionado = false;
            }
            // Apos evitar divisao por zero, liberar os botoes
            else if (btnSoma.Enabled == false)
            {
                txtVisor.Clear();

                // Liberando os botoes de operacoes
                btnSoma.Enabled = true;
                btnSubtracao.Enabled = true;
                btnMultiplicacao.Enabled = true;
                btnDivisao.Enabled = true;
                btnPorcentagem.Enabled = true;
                btnDividex.Enabled = true;
                btnQuadrado.Enabled = true;
                btnRaiz.Enabled = true;
                btnSinal.Enabled = true;
                btnVirgula.Enabled = true;
            }
            // Limpa Visor ao apertar de zero a nove
            else if ((txtVisor.Text == "0") || (operacaoPressionada == true))
            {
                txtVisor.Clear();
            }

            operacaoPressionada = false;
            Button b = (Button)sender;

            // Verificando se existe apenas uma virgula
            if (b.Text == ",")
            {
                if (!txtVisor.Text.Contains(","))
                {
                    txtVisor.Text += b.Text;
                }
            }
            else
            {
                txtVisor.Text += b.Text;
            }  
        }

        // Botoes de soma, subtracao, divisao e multiplicacao
        private void btnOperador_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            valorAtual = Convert.ToDouble(txtVisor.Text);
            operacaoAtual = b.Text;
            operacaoPressionada = true;

            // Se string length maior que 64, define scroll vertical
            if (txtVisorFundo.Text.Length > 54)
            {
                txtVisorFundo.ScrollBars = ScrollBars.Vertical;
            }

            // Evitando divisão por zero
            if ((valorAtual == 0) && (txtVisorFundo.Text[txtVisorFundo.Text.Length - 1] == '÷'))
            {
                txtVisor.Text = "Não dividir por 0";
                txtVisorFundo.Clear();

                // Travando botoes de operacoes
                btnSoma.Enabled = false;
                btnSubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
                btnPorcentagem.Enabled = false;
                btnDividex.Enabled = false;
                btnQuadrado.Enabled = false;
                btnRaiz.Enabled = false;
                btnSinal.Enabled = false;
                btnVirgula.Enabled = false;

                return;
            }

            if (primeiraOperacao == true)
            {
                txtVisorFundo.Text = valorAtual + " " + operacaoAtual;
                acumulado = valorAtual;
                primeiraOperacao = false;
                operacaoAnterior = String.Copy(operacaoAtual);
            }
            // Evitar mais de um clique em sequencia nos botoes %, raiz, 1/x e elevado ao quadrado
            else if (operadorAtivo == true)
            {
                txtVisorFundo.AppendText(" " + operacaoAtual);
                btnResultado.PerformClick();
                operadorAtivo = false;
            }
            else
            {
                txtVisorFundo.AppendText(" " + Math.Abs(valorAtual).ToString() + " " + operacaoAtual);
                temp = String.Copy(operacaoAtual);
                operacaoAtual = String.Copy(operacaoAnterior);
                btnResultado.PerformClick();
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            if (operacaoPressionada == false)
            {
                valorAtual = Convert.ToDouble(txtVisor.Text);
                operacaoAtual = String.Copy(operacaoAnterior);
            }
            
            switch (operacaoAtual)
            {
                case "+":
                    acumulado += valorAtual;
                    break;
                case "-":
                    acumulado -= valorAtual;
                    break;
                case "x":
                    acumulado *= valorAtual;
                    break;
                case "÷":
                    acumulado /= valorAtual;
                    break;
                default:
                    break;
            }

            // Imprimindo na tela ao pressionar o botao igual
            txtVisor.Text = acumulado.ToString();
            if (operacaoPressionada == false)
            {
                txtVisorFundo.AppendText(" " + Math.Abs(valorAtual).ToString() + " =");
                igualPressionado = true;
            }

            // Resetando os valores
            valorAtual = 0;
            operacaoAtual = "";

            // Definindo operacaoAnterior
            if (temp == "")
            {
                operacaoAnterior = String.Copy(operacaoAtual);
            }
            else
            {
                operacaoAnterior = String.Copy(temp);
                temp = "";
            }
        }

        private void btnPorcentagem_click(object sender, EventArgs e)
        {
            // Evita que execute duas vezes seguidas
            if (operadorAtivo == true)
            {
                return;
            }
            else if (primeiraOperacao == true)
            {
                valorAtual = 0;
                acumulado = valorAtual;
                txtVisorFundo.AppendText(acumulado.ToString());
                txtVisor.Text = valorAtual.ToString();
            }
            else
            {
                valorAtual = acumulado * (Convert.ToDouble(txtVisor.Text) / 100);
                txtVisorFundo.AppendText(" " + valorAtual);
                txtVisor.Text = valorAtual.ToString();
                operadorAtivo = true;
            }
        }

        private void btnDividex_click(object sender, EventArgs e)
        {
            // Evita que execute duas vezes seguidas
            if (operadorAtivo == true)
            {
                return;
            }
            else if (primeiraOperacao == true)
            {
                valorAtual = 1 / (Convert.ToDouble(txtVisor.Text));
                acumulado = valorAtual;
                txtVisorFundo.AppendText(acumulado.ToString());
                txtVisor.Text = valorAtual.ToString();
            }
            else
            {
                valorAtual = 1 / (Convert.ToDouble(txtVisor.Text));
                txtVisorFundo.AppendText(" " + "1/(" + txtVisor.Text + ")");
                txtVisor.Text = valorAtual.ToString();
                operadorAtivo = true;
            }
        }

        private void btnQuadrado_click(object sender, EventArgs e)
        {
            if (operadorAtivo == false)
            {
                txtVisorFundo.Text = "sqrt(" + txtVisor.Text + ")";
                operadorAtivo = true;
            }
            else
            {
                txtVisorFundo.Text = "sqtr(" + txtVisorFundo.Text + ")";
            }

            valorAtual = Math.Pow(Convert.ToDouble(txtVisor.Text), 2);
            txtVisor.Text = valorAtual.ToString();
            acumulado += valorAtual;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (operadorAtivo == true)
            {
                return;
            }
            else
            {
                valorAtual = Math.Sqrt(Convert.ToDouble(txtVisor.Text));
                txtVisorFundo.AppendText(" √(" + txtVisor.Text + ")");
                txtVisor.Text = valorAtual.ToString();
                acumulado += valorAtual;
                operadorAtivo = true;

            }
        }

        private void btnSinal_Click(object sender, EventArgs e)
        {
            if (operadorAtivo)
            {
                return;
            }
            else if (Convert.ToDouble(txtVisor.Text) > 0)
            {
                txtVisor.Text = "-" + txtVisor.Text;
            }
            else if (Convert.ToDouble(txtVisor.Text) < 0)
            {
                txtVisor.Text = txtVisor.Text.Remove(0, 1);
            }
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case "+":
                    btnSoma.PerformClick();
                    break;
                case "-":
                    btnSubtracao.PerformClick();
                    break;
                case "*":
                    btnMultiplicacao.PerformClick();
                    break;
                case "/":
                    btnDivisao.PerformClick();
                    break;
                default:
                    break;

            }
        }
    }
}