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

namespace P30482011037
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int i, j;
            int meses = 7; //ultimo digito do RA
            int semanas = 4;
            double[,] matrizVendas = new double[meses, semanas];
            double[] totalPorMes = new double[meses];
            double totalGeral = 0;

            // Limpando dados
            lstbxSaidas.Items.Clear();

            // Iniciando
            lstbxSaidas.Items.Add("Vendas da Loja");
            lstbxSaidas.Items.Add("---------------------------------------------------------");


            // Recebendo dados de vendas
            for (i = 0; i < meses; i++)
            {
                for (j = 0; j < semanas; j++)
                {
                    if (Double.TryParse(Interaction.InputBox($"Digite o valor de vendas da semana {j + 1}:",
                                                             $"Mês {i + 1}"), out double valor))
                    {
                        matrizVendas[i, j] = valor;
                        totalPorMes[i] += valor;
                        totalGeral += valor;
                    }
                    else
                    {
                        MessageBox.Show("Digite um valor válido!");
                        j -= 1;
                    }
                }
            }

            //Mostrando dados
            for (i = 0; i < meses; i++)
            {
                for (j = 0; j < semanas; j++)
                {
                    lstbxSaidas.Items.Add($"Total do mês {i + 1}: Semana {j + 1}: {matrizVendas[i, j]:C2}");
                }

                lstbxSaidas.Items.Add($">> Total mês {i+1}: {totalPorMes[i]:C2}");
                lstbxSaidas.Items.Add("---------------------------------------------------------");
            }

            lstbxSaidas.Items.Add($">> Total Geral: {totalGeral:C2}");
        }
    }
}
