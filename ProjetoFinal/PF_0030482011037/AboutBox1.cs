using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_0030482011037
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.lblProduto.Text = "Cadastro de Cidade";
            this.labelVersion.Text = String.Format("Versão 1.0");
            this.labelCopyright.Text = "Todos os direitos reservados";
            this.labelCompanyName.Text = "Empresa Desenvolvedora Ltda.";
            this.txtbxDescription.Text = "Projeto desenvolvido por Diego da Silva Lourenço durante " +
                "o curso Linguagem de Programação 2 da FATEC sorocaba com a professora Denilce Veloso. " +
                "O objetivo do projeto é criar um cadastro de nome de cidades, onde é possível " +
                "inserir, modificar e excluir cidades.";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
