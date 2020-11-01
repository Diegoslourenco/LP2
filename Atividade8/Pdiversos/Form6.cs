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
    public partial class frm6 : Form
    {
        public frm6()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            int maximoAlunos = 20;
            int colunas = 4;
            string[,] matriz = new string[maximoAlunos, colunas];
            string textoSaida = "";
            double media = 0;
            int i = 0;
            int j;

            while (i < maximoAlunos)
            {
                j = 0;

                while (j < colunas)
                {
                    if (j == 0)
                    {
                        matriz[i, j] = Interaction.InputBox($"Digite o nome do aluno(a) {i + 1}:",
                            "Nome dos alunos");
                        j += 1;
                    }
                    else
                    {
                        if (Double.TryParse((Interaction.InputBox($"Nota {j} de {matriz[i, 0]}:",
                            "Notas")), out double nota))
                        {
                            if (nota < 10 && nota >= 0)
                            {
                                matriz[i, j] = nota.ToString("N2");
                                j += 1;
                            }
                            else
                            {
                                MessageBox.Show("Digite uma nota válida!");
                                continue;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Digite uma nota válida!");
                            continue;
                        }
                    }
                }

                i += 1;
            }

            for (i = 0; i < maximoAlunos; i++)
            {
                media = (Convert.ToDouble(matriz[i, 1]) + Convert.ToDouble(matriz[i, 2]) +
                        Convert.ToDouble(matriz[i, 3])) / 3;
                textoSaida += $"\n{matriz[i, 0]}: média: {media:N2}";
            }

            MessageBox.Show($"Médias dos alunos: {textoSaida}");
        }
    }
}
