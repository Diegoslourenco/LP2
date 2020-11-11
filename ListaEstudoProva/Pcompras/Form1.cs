using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pcompras
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        { 
            int i;
            int j;
            int numeroDiasSemana = 7;
            int numeroProdutos = 5;
            double[,] matrizProdutos = new double[numeroDiasSemana, numeroProdutos];
            double[] totalPorDia = new double[numeroDiasSemana];
            double totalGeral = 0;

            lstbxSaidas.Items.Clear();

            CultureInfo cultura = new System.Globalization.CultureInfo("pt-BR");
            var dia = cultura.DateTimeFormat;

            // Alimenta a matriz de semana por produtos
            for (i = 0; i < numeroDiasSemana; i++)
            {
                for (j = 0; j < numeroProdutos; j++)
                {
                    if (double.TryParse(Interaction.InputBox($"Digite o valor do produto {j + 1}:",
                                                              $"{dia.DayNames[(int)DayOfWeek.Sunday + i]}"),
                                                              out double valor))
                    {
                        matrizProdutos[i, j] = valor;
                    }
                }
            }

            // Soma o total por dia e armazena num vetor
            for (i = 0; i < numeroDiasSemana; i++)
            {
                for (j = 0; j < numeroProdutos; j++)
                {
                    totalPorDia[i] += matrizProdutos[i, j];
                }
            }

            // Total geral
            for (i = 0; i < numeroDiasSemana; i++)
            {
                totalGeral += totalPorDia[i];
            }

            lstbxSaidas.Items.Add("Total por dia:");
            for (i = 0; i < numeroDiasSemana; i++)
            {
                lstbxSaidas.Items.Add($"{dia.DayNames[(int)DayOfWeek.Sunday + i]}: {totalPorDia[i]}");
            }
            lstbxSaidas.Items.Add($"Total Geral: {totalGeral}");
        }
    }
}
