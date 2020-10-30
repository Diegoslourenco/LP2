namespace Pbotoes
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
            this.btnPalindromo = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPalindromo
            // 
            this.btnPalindromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalindromo.Location = new System.Drawing.Point(115, 149);
            this.btnPalindromo.Name = "btnPalindromo";
            this.btnPalindromo.Size = new System.Drawing.Size(189, 33);
            this.btnPalindromo.TabIndex = 4;
            this.btnPalindromo.Text = "Palíndromo";
            this.btnPalindromo.UseVisualStyleBackColor = true;
            this.btnPalindromo.Click += new System.EventHandler(this.btnPalindromo_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(12, 81);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(395, 22);
            this.txtTexto.TabIndex = 3;
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 263);
            this.Controls.Add(this.btnPalindromo);
            this.Controls.Add(this.txtTexto);
            this.Name = "frm3";
            this.Text = "Form 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPalindromo;
        private System.Windows.Forms.TextBox txtTexto;
    }
}