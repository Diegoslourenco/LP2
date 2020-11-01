using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Pdiversos
{
    public partial class frm5 : Form
    {
        public frm5()
        {
            InitializeComponent();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            string texto = "";

            // Alimentando a lista de nomes
            lista.Add("Ana");
            lista.Add("André");
            lista.Add("Débora");
            lista.Add("Fátima");
            lista.Add("João");
            lista.Add("Janete");
            lista.Add("Otávio");
            lista.Add("Marcelo");
            lista.Add("Pedro");
            lista.Add("Thais");

            // Removendo Otávio
            lista.Remove("Otávio");

            foreach (var nome in lista)
            {
                texto += "\n" + nome;
            }

            MessageBox.Show($"Os nomes na lista são:{texto}");
        }
    }
}
