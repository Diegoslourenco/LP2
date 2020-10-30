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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Double numeroH = 0;

            if (Double.TryParse(txtNumero.Text, out Double numeroN))
            {
                for (int i = 0; i < numeroN; i++)
                {
                    numeroH += 1.0 / (Double.Parse(i.ToString("N2")) + 1.0);
                }

                MessageBox.Show($"H: {numeroH:N2}");
            }
            else
            {
                MessageBox.Show("Digite um número válido!");
            }
        }
    }
}
