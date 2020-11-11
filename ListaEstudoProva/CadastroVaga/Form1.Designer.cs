namespace CadastroVaga
{
    partial class frmVaga
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.cbxIdade = new System.Windows.Forms.ComboBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.pnlEstadoCivil = new System.Windows.Forms.Panel();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.rbtnOutros = new System.Windows.Forms.RadioButton();
            this.rbtnViuvo = new System.Windows.Forms.RadioButton();
            this.rbtnDivorciado = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.cklbSexo = new System.Windows.Forms.CheckedListBox();
            this.ckbxMasculino = new System.Windows.Forms.CheckBox();
            this.ckbxFeminino = new System.Windows.Forms.CheckBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.cbxDistancia = new System.Windows.Forms.ComboBox();
            this.lblEmpresaAnterior = new System.Windows.Forms.Label();
            this.txtEmpresaAnterior = new System.Windows.Forms.TextBox();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.cbxExperiencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.btnCandidatar = new System.Windows.Forms.Button();
            this.pnlEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(232, 13);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 24);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(18, 12);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(18, 51);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(73, 18);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(232, 51);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(180, 24);
            this.txtTelefone.TabIndex = 2;
            // 
            // cbxIdade
            // 
            this.cbxIdade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdade.FormattingEnabled = true;
            this.cbxIdade.Location = new System.Drawing.Point(232, 94);
            this.cbxIdade.Margin = new System.Windows.Forms.Padding(4);
            this.cbxIdade.Name = "cbxIdade";
            this.cbxIdade.Size = new System.Drawing.Size(180, 26);
            this.cbxIdade.TabIndex = 4;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(18, 97);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(48, 18);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade";
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Checked = true;
            this.rbtnSolteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSolteiro.Location = new System.Drawing.Point(22, 31);
            this.rbtnSolteiro.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(77, 22);
            this.rbtnSolteiro.TabIndex = 6;
            this.rbtnSolteiro.TabStop = true;
            this.rbtnSolteiro.Text = "Solteiro";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // pnlEstadoCivil
            // 
            this.pnlEstadoCivil.Controls.Add(this.lblEstadoCivil);
            this.pnlEstadoCivil.Controls.Add(this.rbtnOutros);
            this.pnlEstadoCivil.Controls.Add(this.rbtnViuvo);
            this.pnlEstadoCivil.Controls.Add(this.rbtnDivorciado);
            this.pnlEstadoCivil.Controls.Add(this.rbtnCasado);
            this.pnlEstadoCivil.Controls.Add(this.rbtnSolteiro);
            this.pnlEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEstadoCivil.Location = new System.Drawing.Point(445, 135);
            this.pnlEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEstadoCivil.Name = "pnlEstadoCivil";
            this.pnlEstadoCivil.Size = new System.Drawing.Size(124, 157);
            this.pnlEstadoCivil.TabIndex = 7;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(16, 6);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(98, 18);
            this.lblEstadoCivil.TabIndex = 8;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // rbtnOutros
            // 
            this.rbtnOutros.AutoSize = true;
            this.rbtnOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOutros.Location = new System.Drawing.Point(21, 131);
            this.rbtnOutros.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnOutros.Name = "rbtnOutros";
            this.rbtnOutros.Size = new System.Drawing.Size(72, 22);
            this.rbtnOutros.TabIndex = 10;
            this.rbtnOutros.TabStop = true;
            this.rbtnOutros.Text = "Outros";
            this.rbtnOutros.UseVisualStyleBackColor = true;
            // 
            // rbtnViuvo
            // 
            this.rbtnViuvo.AutoSize = true;
            this.rbtnViuvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnViuvo.Location = new System.Drawing.Point(22, 83);
            this.rbtnViuvo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnViuvo.Name = "rbtnViuvo";
            this.rbtnViuvo.Size = new System.Drawing.Size(62, 22);
            this.rbtnViuvo.TabIndex = 9;
            this.rbtnViuvo.TabStop = true;
            this.rbtnViuvo.Text = "Viúvo";
            this.rbtnViuvo.UseVisualStyleBackColor = true;
            // 
            // rbtnDivorciado
            // 
            this.rbtnDivorciado.AutoSize = true;
            this.rbtnDivorciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDivorciado.Location = new System.Drawing.Point(22, 108);
            this.rbtnDivorciado.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDivorciado.Name = "rbtnDivorciado";
            this.rbtnDivorciado.Size = new System.Drawing.Size(97, 22);
            this.rbtnDivorciado.TabIndex = 8;
            this.rbtnDivorciado.TabStop = true;
            this.rbtnDivorciado.Text = "Divorciado";
            this.rbtnDivorciado.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCasado.Location = new System.Drawing.Point(21, 57);
            this.rbtnCasado.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(78, 22);
            this.rbtnCasado.TabIndex = 7;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // cklbSexo
            // 
            this.cklbSexo.CheckOnClick = true;
            this.cklbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklbSexo.FormattingEnabled = true;
            this.cklbSexo.Location = new System.Drawing.Point(445, 12);
            this.cklbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cklbSexo.Name = "cklbSexo";
            this.cklbSexo.Size = new System.Drawing.Size(180, 99);
            this.cklbSexo.TabIndex = 8;
            // 
            // ckbxMasculino
            // 
            this.ckbxMasculino.AutoSize = true;
            this.ckbxMasculino.Checked = true;
            this.ckbxMasculino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxMasculino.Location = new System.Drawing.Point(455, 44);
            this.ckbxMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxMasculino.Name = "ckbxMasculino";
            this.ckbxMasculino.Size = new System.Drawing.Size(95, 22);
            this.ckbxMasculino.TabIndex = 9;
            this.ckbxMasculino.Text = "Masculino";
            this.ckbxMasculino.UseVisualStyleBackColor = true;
            this.ckbxMasculino.CheckedChanged += new System.EventHandler(this.ckbxMasculino_CheckedChanged);
            // 
            // ckbxFeminino
            // 
            this.ckbxFeminino.AutoSize = true;
            this.ckbxFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxFeminino.Location = new System.Drawing.Point(455, 80);
            this.ckbxFeminino.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxFeminino.Name = "ckbxFeminino";
            this.ckbxFeminino.Size = new System.Drawing.Size(88, 22);
            this.ckbxFeminino.TabIndex = 10;
            this.ckbxFeminino.Text = "Feminino";
            this.ckbxFeminino.UseVisualStyleBackColor = true;
            this.ckbxFeminino.CheckedChanged += new System.EventHandler(this.ckbxFeminino_CheckedChanged);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(18, 139);
            this.lblDistancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(190, 18);
            this.lblDistancia.TabIndex = 13;
            this.lblDistancia.Text = "Distância até a empresa";
            // 
            // cbxDistancia
            // 
            this.cbxDistancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDistancia.FormattingEnabled = true;
            this.cbxDistancia.Location = new System.Drawing.Point(232, 135);
            this.cbxDistancia.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDistancia.Name = "cbxDistancia";
            this.cbxDistancia.Size = new System.Drawing.Size(180, 26);
            this.cbxDistancia.TabIndex = 12;
            // 
            // lblEmpresaAnterior
            // 
            this.lblEmpresaAnterior.AutoSize = true;
            this.lblEmpresaAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaAnterior.Location = new System.Drawing.Point(18, 182);
            this.lblEmpresaAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresaAnterior.Name = "lblEmpresaAnterior";
            this.lblEmpresaAnterior.Size = new System.Drawing.Size(139, 18);
            this.lblEmpresaAnterior.TabIndex = 15;
            this.lblEmpresaAnterior.Text = "Empresa Anterior";
            // 
            // txtEmpresaAnterior
            // 
            this.txtEmpresaAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresaAnterior.Location = new System.Drawing.Point(232, 180);
            this.txtEmpresaAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpresaAnterior.Name = "txtEmpresaAnterior";
            this.txtEmpresaAnterior.Size = new System.Drawing.Size(180, 24);
            this.txtEmpresaAnterior.TabIndex = 14;
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperiencia.Location = new System.Drawing.Point(18, 229);
            this.lblExperiencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(175, 18);
            this.lblExperiencia.TabIndex = 17;
            this.lblExperiencia.Text = "Tempo de Experiência";
            // 
            // cbxExperiencia
            // 
            this.cbxExperiencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxExperiencia.FormattingEnabled = true;
            this.cbxExperiencia.Location = new System.Drawing.Point(232, 225);
            this.cbxExperiencia.Margin = new System.Windows.Forms.Padding(4);
            this.cbxExperiencia.Name = "cbxExperiencia";
            this.cbxExperiencia.Size = new System.Drawing.Size(180, 26);
            this.cbxExperiencia.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Salário Pretendido";
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Location = new System.Drawing.Point(232, 274);
            this.mskbxSalario.Mask = "$ 9999.99";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(180, 24);
            this.mskbxSalario.TabIndex = 19;
            this.mskbxSalario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnCandidatar
            // 
            this.btnCandidatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidatar.Location = new System.Drawing.Point(202, 325);
            this.btnCandidatar.Name = "btnCandidatar";
            this.btnCandidatar.Size = new System.Drawing.Size(153, 51);
            this.btnCandidatar.TabIndex = 20;
            this.btnCandidatar.Text = "Candidatar";
            this.btnCandidatar.UseVisualStyleBackColor = true;
            this.btnCandidatar.Click += new System.EventHandler(this.btnCandidatar_Click);
            // 
            // frmVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 393);
            this.Controls.Add(this.btnCandidatar);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExperiencia);
            this.Controls.Add(this.cbxExperiencia);
            this.Controls.Add(this.lblEmpresaAnterior);
            this.Controls.Add(this.txtEmpresaAnterior);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.cbxDistancia);
            this.Controls.Add(this.ckbxFeminino);
            this.Controls.Add(this.ckbxMasculino);
            this.Controls.Add(this.cklbSexo);
            this.Controls.Add(this.pnlEstadoCivil);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.cbxIdade);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVaga";
            this.Text = "Cadastro de Vaga";
            this.pnlEstadoCivil.ResumeLayout(false);
            this.pnlEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.ComboBox cbxIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.Panel pnlEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnOutros;
        private System.Windows.Forms.RadioButton rbtnViuvo;
        private System.Windows.Forms.RadioButton rbtnDivorciado;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.CheckedListBox cklbSexo;
        private System.Windows.Forms.CheckBox ckbxMasculino;
        private System.Windows.Forms.CheckBox ckbxFeminino;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.ComboBox cbxDistancia;
        private System.Windows.Forms.Label lblEmpresaAnterior;
        private System.Windows.Forms.TextBox txtEmpresaAnterior;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.ComboBox cbxExperiencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.Button btnCandidatar;
    }
}

