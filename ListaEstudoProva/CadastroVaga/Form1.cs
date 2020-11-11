using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroVaga
{
    public partial class frmVaga : Form
    {
        public frmVaga()
        {
            InitializeComponent();

            // Alimentando campo idade
            int idadeMinima = 18;
            int idadeMaxima = 75;

            for (int i = idadeMinima; i <= idadeMaxima; i++)
            {
                cbxIdade.Items.Add(i);
            }

            // Alimentando campo distância
            cbxDistancia.Items.Add("0 até 20km");
            cbxDistancia.Items.Add("21 até 50km");
            cbxDistancia.Items.Add("51 até 100km");
            cbxDistancia.Items.Add("Maior que 100km");

            // Alimentando campo de experiência
            cbxExperiencia.Items.Add("Até um ano");
            cbxExperiencia.Items.Add("De um a dois anos");
            cbxExperiencia.Items.Add("de dois a três anos");
            cbxExperiencia.Items.Add("de três a cinco anos");
            cbxExperiencia.Items.Add("mais de cinco anos");
        }

        private void btnCandidatar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha seu nome!");
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha seu telefone!");
            }
            else if (txtEmpresaAnterior.Text == "")
            {
                MessageBox.Show("Preencha a empresa anterior!");
            }
            else if (cbxIdade.Text == "")
            {
                MessageBox.Show("Preencha sua idade!");
            }
            else if (cbxDistancia.Text == "")
            {
                MessageBox.Show("Preencha a distância até a empresa");
            }
            else if (cbxExperiencia.Text == "")
            {
                MessageBox.Show("Preencha sua experiência anterior!");
            }
            else if (mskbxSalario.Text == "")
            {
                MessageBox.Show("Preencha o valor do salário pretendido!");
            }
            else
            {
                // Testando se o nome tem apenas texto
                for (var i = 0; i < txtNome.Text.Length; i++)
                {
                    if ((Char.IsLetter(txtNome.Text[i]) == false) &&
                        (Char.IsWhiteSpace(txtNome.Text[i]) == false))
                    {
                        MessageBox.Show("Digite apenas letras no campo Nome!");
                        return;
                    }
                }

                // Testando se o telefone tem apenas números
                for (var i = 0; i < txtTelefone.Text.Length; i++)
                {
                    if (Char.IsNumber(txtTelefone.Text[i]) == false)
                    {
                        MessageBox.Show("Digite apenas números no campo telefone!");
                        return;
                    }
                }

                // Verificando se tem mais de um ano de experiência
                if (cbxExperiencia.Text == "Até um ano")
                {
                    MessageBox.Show("Obrigado pela participação, " +
                                    "porém você não preenche os requisitos da vaga no momento.");
                }
                else if (cbxDistancia.Text == "Maior que 100km")
                {
                    MessageBox.Show("Obrigado pelo interesse.\n" +
                                    "Infelizmente você não preenche os requisitos, " +
                                    "pois a empresa não fornece transporte.");
                }
                else if (((Convert.ToDouble(mskbxSalario.Text) / 100) < 1000) ||
                         ((Convert.ToDouble(mskbxSalario.Text) / 100) > 2500))
                {
                    MessageBox.Show("Obrigado pela participação, " +
                                    "mas você não atende os requisitos da vaga.");

                }
                else if (cbxExperiencia.Text == "De um a dois anos")
                {
                    MessageBox.Show("Você será chamado para um teste. Aguarde!");
                }
                else
                {
                    MessageBox.Show("Obrigado pelo cadastro. " +
                                    "Entraremos em contato para as próximas fases");
                }


            }
        }

        private void ckbxMasculino_CheckedChanged(object sender, EventArgs e)
        {
            ckbxFeminino.Checked = !ckbxMasculino.Checked;
        }

        private void ckbxFeminino_CheckedChanged(object sender, EventArgs e)
        {
            ckbxMasculino.Checked = !ckbxFeminino.Checked;
        }
    }
}
