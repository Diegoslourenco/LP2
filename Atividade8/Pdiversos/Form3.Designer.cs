namespace Pdiversos
{
    partial class frm3
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
            this.btnFaturamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFaturamento
            // 
            this.btnFaturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturamento.Location = new System.Drawing.Point(265, 128);
            this.btnFaturamento.Name = "btnFaturamento";
            this.btnFaturamento.Size = new System.Drawing.Size(124, 65);
            this.btnFaturamento.TabIndex = 2;
            this.btnFaturamento.Text = "Calcula Faturamento";
            this.btnFaturamento.UseVisualStyleBackColor = true;
            this.btnFaturamento.Click += new System.EventHandler(this.btnFaturamento_Click);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 321);
            this.Controls.Add(this.btnFaturamento);
            this.Name = "frm3";
            this.Text = "Formulário 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFaturamento;
    }
}