namespace Pmetodos
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContaLetra = new System.Windows.Forms.Button();
            this.btnPosicao = new System.Windows.Forms.Button();
            this.btnContaNumero = new System.Windows.Forms.Button();
            this.rchtxtText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnContaLetra
            // 
            this.btnContaLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaLetra.Location = new System.Drawing.Point(387, 192);
            this.btnContaLetra.Name = "btnContaLetra";
            this.btnContaLetra.Size = new System.Drawing.Size(100, 78);
            this.btnContaLetra.TabIndex = 20;
            this.btnContaLetra.Text = "Conta Letras";
            this.btnContaLetra.UseVisualStyleBackColor = true;
            this.btnContaLetra.Click += new System.EventHandler(this.btnContaLetra_Click);
            // 
            // btnPosicao
            // 
            this.btnPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicao.Location = new System.Drawing.Point(221, 192);
            this.btnPosicao.Name = "btnPosicao";
            this.btnPosicao.Size = new System.Drawing.Size(141, 78);
            this.btnPosicao.TabIndex = 19;
            this.btnPosicao.Text = "Posição";
            this.btnPosicao.UseVisualStyleBackColor = true;
            this.btnPosicao.Click += new System.EventHandler(this.btnPosicao_Click);
            // 
            // btnContaNumero
            // 
            this.btnContaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaNumero.Location = new System.Drawing.Point(67, 192);
            this.btnContaNumero.Name = "btnContaNumero";
            this.btnContaNumero.Size = new System.Drawing.Size(106, 78);
            this.btnContaNumero.TabIndex = 18;
            this.btnContaNumero.Text = "Conta Números";
            this.btnContaNumero.UseVisualStyleBackColor = true;
            this.btnContaNumero.Click += new System.EventHandler(this.btnContaNumero_Click);
            // 
            // rchtxtText
            // 
            this.rchtxtText.Location = new System.Drawing.Point(67, 20);
            this.rchtxtText.Name = "rchtxtText";
            this.rchtxtText.Size = new System.Drawing.Size(420, 147);
            this.rchtxtText.TabIndex = 21;
            this.rchtxtText.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 325);
            this.Controls.Add(this.rchtxtText);
            this.Controls.Add(this.btnContaLetra);
            this.Controls.Add(this.btnPosicao);
            this.Controls.Add(this.btnContaNumero);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContaLetra;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.Button btnContaNumero;
        private System.Windows.Forms.RichTextBox rchtxtText;
    }
}