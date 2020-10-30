namespace Pbotoes
{
    partial class frm2
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnNumero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(128, 66);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 22);
            this.txtNumero.TabIndex = 0;
            // 
            // btnNumero
            // 
            this.btnNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero.Location = new System.Drawing.Point(106, 134);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(189, 33);
            this.btnNumero.TabIndex = 2;
            this.btnNumero.Text = "Gerar Número H";
            this.btnNumero.UseVisualStyleBackColor = true;
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 263);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.txtNumero);
            this.Location = new System.Drawing.Point(113, 219);
            this.Name = "frm2";
            this.Text = "Form 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnNumero;
    }
}