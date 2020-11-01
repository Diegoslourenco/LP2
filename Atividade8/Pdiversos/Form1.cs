﻿using System;
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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            int maximo = 20;
            double[] vetor = new double[maximo];
            string texto = "";
            int i = 0;

            while (i < maximo)
            {
               if(Double.TryParse((Interaction.InputBox($"Digite a posição {i+1} do vetor:", "Entrada de Dados")), out vetor[i]))
               {
                    i += 1;
               }
               else
               {
                    MessageBox.Show("Digite um valor numérico!");
                    continue;
               }
            }

            for (i = maximo - 1; i >= 0; i--)
            {
                texto += vetor[i];
            }

            MessageBox.Show($"{texto}");          
        }
    }
}
