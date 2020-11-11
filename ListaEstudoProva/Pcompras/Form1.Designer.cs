namespace Pcompras
{
    partial class frmCompras
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
            this.lstbxSaidas = new System.Windows.Forms.ListBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxSaidas
            // 
            this.lstbxSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxSaidas.FormattingEnabled = true;
            this.lstbxSaidas.ItemHeight = 20;
            this.lstbxSaidas.Location = new System.Drawing.Point(189, 57);
            this.lstbxSaidas.Name = "lstbxSaidas";
            this.lstbxSaidas.Size = new System.Drawing.Size(223, 204);
            this.lstbxSaidas.TabIndex = 6;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(90, 109);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 35);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(185, 9);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(187, 24);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Compras da Semana";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 273);
            this.Controls.Add(this.lstbxSaidas);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblTexto);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxSaidas;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTexto;
    }
}

