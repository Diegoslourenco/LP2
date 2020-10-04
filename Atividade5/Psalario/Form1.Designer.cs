namespace Psalario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mskbxNomeFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroFilhos = new System.Windows.Forms.Label();
            this.mskbxNumeroFilhos = new System.Windows.Forms.MaskedTextBox();
            this.gbxGenero = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.pnlCasado = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblDados = new System.Windows.Forms.Label();
            this.pnlSaidas = new System.Windows.Forms.Panel();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbxGenero.SuspendLayout();
            this.pnlCasado.SuspendLayout();
            this.pnlSaidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskbxNomeFuncionario
            // 
            this.mskbxNomeFuncionario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxNomeFuncionario.Location = new System.Drawing.Point(223, 7);
            this.mskbxNomeFuncionario.Name = "mskbxNomeFuncionario";
            this.mskbxNomeFuncionario.Size = new System.Drawing.Size(361, 33);
            this.mskbxNomeFuncionario.TabIndex = 0;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(22, 9);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(179, 23);
            this.lblNomeFuncionario.TabIndex = 1;
            this.lblNomeFuncionario.Text = "Nome do Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(22, 51);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(113, 23);
            this.lblSalarioBruto.TabIndex = 3;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(223, 46);
            this.mskbxSalarioBruto.Mask = "$ 99000,00";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(116, 33);
            this.mskbxSalarioBruto.TabIndex = 2;
            this.mskbxSalarioBruto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblNumeroFilhos
            // 
            this.lblNumeroFilhos.AutoSize = true;
            this.lblNumeroFilhos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFilhos.Location = new System.Drawing.Point(22, 87);
            this.lblNumeroFilhos.Name = "lblNumeroFilhos";
            this.lblNumeroFilhos.Size = new System.Drawing.Size(150, 23);
            this.lblNumeroFilhos.TabIndex = 5;
            this.lblNumeroFilhos.Text = "Número de Filhos";
            // 
            // mskbxNumeroFilhos
            // 
            this.mskbxNumeroFilhos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxNumeroFilhos.Location = new System.Drawing.Point(223, 85);
            this.mskbxNumeroFilhos.Mask = "90";
            this.mskbxNumeroFilhos.Name = "mskbxNumeroFilhos";
            this.mskbxNumeroFilhos.Size = new System.Drawing.Size(116, 33);
            this.mskbxNumeroFilhos.TabIndex = 4;
            // 
            // gbxGenero
            // 
            this.gbxGenero.Controls.Add(this.rbtnMasculino);
            this.gbxGenero.Controls.Add(this.rbtnFeminino);
            this.gbxGenero.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGenero.Location = new System.Drawing.Point(345, 46);
            this.gbxGenero.Name = "gbxGenero";
            this.gbxGenero.Size = new System.Drawing.Size(130, 138);
            this.gbxGenero.TabIndex = 6;
            this.gbxGenero.TabStop = false;
            this.gbxGenero.Text = "Gênero";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(6, 95);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(110, 27);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFeminino.Location = new System.Drawing.Point(6, 37);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(102, 27);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // pnlCasado
            // 
            this.pnlCasado.Controls.Add(this.ckbxCasado);
            this.pnlCasado.Location = new System.Drawing.Point(485, 59);
            this.pnlCasado.Name = "pnlCasado";
            this.pnlCasado.Size = new System.Drawing.Size(99, 65);
            this.pnlCasado.TabIndex = 7;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxCasado.Location = new System.Drawing.Point(8, 22);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(85, 27);
            this.ckbxCasado.TabIndex = 0;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(26, 124);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(185, 60);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(6, 16);
            this.lblDados.MaximumSize = new System.Drawing.Size(550, 120);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(59, 23);
            this.lblDados.TabIndex = 9;
            this.lblDados.Text = "Dados";
            // 
            // pnlSaidas
            // 
            this.pnlSaidas.Controls.Add(this.txtDescontoIRPF);
            this.pnlSaidas.Controls.Add(this.lblDados);
            this.pnlSaidas.Controls.Add(this.lblSalarioLiquido);
            this.pnlSaidas.Controls.Add(this.txtDescontoINSS);
            this.pnlSaidas.Controls.Add(this.lblSalarioFamilia);
            this.pnlSaidas.Controls.Add(this.txtSalarioLiquido);
            this.pnlSaidas.Controls.Add(this.lblAliquotaIRPF);
            this.pnlSaidas.Controls.Add(this.txtSalarioFamilia);
            this.pnlSaidas.Controls.Add(this.lblAliquotaINSS);
            this.pnlSaidas.Controls.Add(this.txtAliquotaIRPF);
            this.pnlSaidas.Controls.Add(this.txtAliquotaINSS);
            this.pnlSaidas.Controls.Add(this.lblDescontoINSS);
            this.pnlSaidas.Controls.Add(this.lblDescontoIRPF);
            this.pnlSaidas.Enabled = false;
            this.pnlSaidas.Location = new System.Drawing.Point(26, 190);
            this.pnlSaidas.Name = "pnlSaidas";
            this.pnlSaidas.Size = new System.Drawing.Size(558, 242);
            this.pnlSaidas.TabIndex = 10;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoIRPF.Location = new System.Drawing.Point(426, 119);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(126, 29);
            this.txtDescontoIRPF.TabIndex = 25;
            this.txtDescontoIRPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(3, 201);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(126, 23);
            this.lblSalarioLiquido.TabIndex = 14;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoINSS.Location = new System.Drawing.Point(426, 72);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(126, 29);
            this.txtDescontoINSS.TabIndex = 24;
            this.txtDescontoINSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFamilia.Location = new System.Drawing.Point(3, 159);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(124, 23);
            this.lblSalarioFamilia.TabIndex = 15;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioLiquido.Location = new System.Drawing.Point(150, 200);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(126, 29);
            this.txtSalarioLiquido.TabIndex = 23;
            this.txtSalarioLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(3, 119);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(117, 23);
            this.lblAliquotaIRPF.TabIndex = 16;
            this.lblAliquotaIRPF.Text = "Alíquota IRPF";
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFamilia.Location = new System.Drawing.Point(150, 158);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(126, 29);
            this.txtSalarioFamilia.TabIndex = 22;
            this.txtSalarioFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliquotaINSS.Location = new System.Drawing.Point(3, 75);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(118, 23);
            this.lblAliquotaINSS.TabIndex = 17;
            this.lblAliquotaINSS.Text = "Alíquota INSS";
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(150, 115);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(126, 29);
            this.txtAliquotaIRPF.TabIndex = 21;
            this.txtAliquotaIRPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaINSS.Location = new System.Drawing.Point(150, 72);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(126, 29);
            this.txtAliquotaINSS.TabIndex = 18;
            this.txtAliquotaINSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoINSS.Location = new System.Drawing.Point(292, 75);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(125, 23);
            this.lblDescontoINSS.TabIndex = 20;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoIRPF.Location = new System.Drawing.Point(295, 121);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(124, 23);
            this.lblDescontoIRPF.TabIndex = 19;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(217, 124);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 60);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(613, 444);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pnlSaidas);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.pnlCasado);
            this.Controls.Add(this.gbxGenero);
            this.Controls.Add(this.lblNumeroFilhos);
            this.Controls.Add(this.mskbxNumeroFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.mskbxNomeFuncionario);
            this.Name = "Form1";
            this.Text = "Calculadora de Salário Liquido";
            this.gbxGenero.ResumeLayout(false);
            this.gbxGenero.PerformLayout();
            this.pnlCasado.ResumeLayout(false);
            this.pnlCasado.PerformLayout();
            this.pnlSaidas.ResumeLayout(false);
            this.pnlSaidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskbxNomeFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.Label lblNumeroFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxNumeroFilhos;
        private System.Windows.Forms.GroupBox gbxGenero;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Panel pnlCasado;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Panel pnlSaidas;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.Button btnLimpar;
    }
}

