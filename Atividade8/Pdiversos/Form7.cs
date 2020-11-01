using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pdiversos
{
    public partial class frm7 : Form
    {
        public frm7()
        {
            InitializeComponent();
        }

        private void btnNomes_Click(object sender, EventArgs e)
        {
            int maximo = 7;
            int[] comprimento = new int[maximo];
            string[] nomes = new string[maximo];
            string textoSaida = "";
            

            for (int i = 0; i < maximo; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite o {i + 1}º  nome completo:", "Lista de Nomes");
            }

            for (int i = 0; i < maximo; i++)
            {
                foreach (char letra in nomes[i])
                {
                    comprimento[i] += 1;
                }
            }

            for (int i = 0; i < maximo; i++)
            {
                lstbx.Items.Add($"\n {nomes[i]} tem {comprimento[i]} caracteres");
            }
        }
    }
}
