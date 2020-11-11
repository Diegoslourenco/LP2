using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorMedidas
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();

            cbxUnidades.Items.Add("Arroba para Quilo");
            cbxUnidades.Items.Add("Libra para Quilo");
            cbxUnidades.Items.Add("Onça para Grama");
            cbxUnidades.Items.Add("Acre para Hectares");
            cbxUnidades.Items.Add("Hectare para Metro2");
            cbxUnidades.Items.Add("AlqueireMG para Hectare");
            cbxUnidades.Items.Add("AlqueireSP para Hectare");
            cbxUnidades.Items.Add("AlqueireNorte para Hectare");
            cbxUnidades.Items.Add("Braça para Metro");
            cbxUnidades.Items.Add("Jarda para Metro");
            cbxUnidades.Items.Add("Pé para Centímetro");
            cbxUnidades.Items.Add("Polegada para Centímetro");
            cbxUnidades.Items.Add("Milha para Quilometro");
        }

        public static class Constantes
        {
            public static readonly Double[] vetorConversor =
            {
            15.0,
            0.4535923,
            28.349,
            0.4046856224,
            10000.0,
            4.84,
            2.42,
            2.72,
            1.8288,
            0.9144,
            30.48,
            2.54,
            1.609344
            };
        }

        private void txtEnter_KeyPressDePara(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;

                Double valorSaida;

                if (Double.TryParse(txtDe.Text, out Double valorEntrada))
                {
                    valorSaida = valorEntrada * Constantes.vetorConversor[cbxUnidades.SelectedIndex];
                    txtPara.Text = $"{valorSaida:N2}";
                }
            }
        }

        private void txtEnter_KeyPressParaDe(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;

                Double valorSaida;

                if (Double.TryParse(txtPara.Text, out Double valorEntrada))
                {
                    valorSaida = valorEntrada / Constantes.vetorConversor[cbxUnidades.SelectedIndex];
                    txtDe.Text = $"{valorSaida:N2}";
                }
            }
        }

        private void cbxUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDe.Clear();
            txtDe.Focus();
            txtPara.Clear();
        }
    }
}
