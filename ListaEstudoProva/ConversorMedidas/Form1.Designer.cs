namespace ConversorMedidas
{
    partial class frmConversor
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
            this.lblConversor = new System.Windows.Forms.Label();
            this.cbxUnidades = new System.Windows.Forms.ComboBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblConversor
            // 
            this.lblConversor.AutoSize = true;
            this.lblConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversor.Location = new System.Drawing.Point(25, 24);
            this.lblConversor.Name = "lblConversor";
            this.lblConversor.Size = new System.Drawing.Size(110, 24);
            this.lblConversor.TabIndex = 0;
            this.lblConversor.Text = "Conversão";
            // 
            // cbxUnidades
            // 
            this.cbxUnidades.FormattingEnabled = true;
            this.cbxUnidades.Location = new System.Drawing.Point(29, 66);
            this.cbxUnidades.Name = "cbxUnidades";
            this.cbxUnidades.Size = new System.Drawing.Size(121, 21);
            this.cbxUnidades.TabIndex = 1;
            this.cbxUnidades.SelectedIndexChanged += new System.EventHandler(this.cbxUnidades_SelectedIndexChanged);
            // 
            // txtDe
            // 
            this.txtDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDe.Location = new System.Drawing.Point(29, 129);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 26);
            this.txtDe.TabIndex = 2;
            this.txtDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnter_KeyPressDePara);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(25, 102);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(34, 20);
            this.lblDe.TabIndex = 3;
            this.lblDe.Text = "De:";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.Location = new System.Drawing.Point(25, 165);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(46, 20);
            this.lblPara.TabIndex = 5;
            this.lblPara.Text = "Para:";
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Location = new System.Drawing.Point(29, 193);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(100, 26);
            this.txtPara.TabIndex = 4;
            this.txtPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnter_KeyPressParaDe);
            // 
            // frmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 244);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.cbxUnidades);
            this.Controls.Add(this.lblConversor);
            this.Name = "frmConversor";
            this.Text = "Conversor de Medidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversor;
        private System.Windows.Forms.ComboBox cbxUnidades;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.TextBox txtPara;
    }
}

