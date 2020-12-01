using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PF_0030482011037
{
    public partial class frmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();

        /*
            Meus Componentes (Grid, textbox, combobox)
                |
                |
            BindingSource
                |
                |
            DataSet
                |
                |
            DataTable --> SqlDataAdapter (listar)
                |
                |
            SqlConnection --> frmPrincipal
         
         */ 

        public frmCidade()
        {
            InitializeComponent();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            try
            {
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                bnCidade.DataSource = dsCidade.Tables["TBCidade"]; // bindingSource
                dgvCidade.DataSource = bnCidade;

                
                bnvCidade.BindingSource = bnCidade;

                txtId.DataBindings.Add("TEXT", bnCidade, "id_cidade");
                txtCidade.DataBindings.Add("TEXT", bnCidade, "nome_cidade");
                cbxEstado.DataBindings.Add("SelectedItem", bnCidade, "uf_cidade");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            bnCidade.AddNew();              // Add novo registro
            txtCidade.Enabled = true;       // Habilitando para edição
            cbxEstado.Enabled = true;
            cbxEstado.SelectedIndex = 0;    // Vai para o primeiro, impedir que o usuario nao escolha nenhum
            txtCidade.Focus();              // Foco no nome
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            bInclusao = true;               //Para diferenciar se vem de uma inclusao
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validando os dados
            if (txtCidade.Text == "")
            {
                MessageBox.Show("Cidade inválida!");
            }
            else
            {
                Cidade RegCid = new Cidade();
                RegCid.IdCidade = Convert.ToInt16(txtId.Text);
                RegCid.NomeCidade = txtCidade.Text;
                RegCid.UfCidade = cbxEstado.SelectedItem.ToString();
                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Cidade adicionada com sucesso!");
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtCidade.Enabled = false;
                        cbxEstado.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnCancelar.Enabled = false;
                        bInclusao = false;

                        // recarrega o grid
                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade alterada com sucesso!");
                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        txtId.Enabled = false;
                        txtCidade.Enabled = false;
                        cbxEstado.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();
                RegCid.IdCidade = Convert.ToInt16(txtId.Text);
                RegCid.NomeCidade = txtCidade.Text;
                RegCid.UfCidade = cbxEstado.SelectedItem.ToString();

                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluída com sucesso!");
                    Cidade R = new Cidade();
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cidade!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            {
                if (tbCidade.SelectedIndex == 0)
                {
                    tbCidade.SelectTab(1);
                }
                txtCidade.Enabled = true;
                cbxEstado.Enabled = true;
                btnSalvar.Enabled = true;
                txtCidade.Focus();
                btnAlterar.Enabled = false;
                btnNovo.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = true;
                bInclusao = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit();
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            txtCidade.Enabled = false;
            cbxEstado.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
