using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaVolumeCilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha a aplicação
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // limpando os dados
            txtAltura.Clear();
            txtRaio.Clear();
            txtVolume.Clear();
            txtAltura.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Definindo variáveis
            double altura, raio, volume;

            // Verificando se os campos não estao vazios
            if (txtAltura.Text == "" || txtRaio.Text == "")
            {
                MessageBox.Show("Insira valores!");
                return;
            }

            // Verificando validade dos dados e calculando
            if (double.TryParse(txtAltura.Text, out altura) && (double.TryParse(txtRaio.Text, out raio)))
            {
                volume = Math.PI * Math.Pow(raio, 2) * altura;

                txtVolume.Text = volume.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13) // transforma o 13 em caracter, da tabela é o enter
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; // desativa o som beep
            }
        }
    }
}
