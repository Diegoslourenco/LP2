namespace Pdiversos
{
    partial class frm5
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
            this.btnLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(265, 128);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(124, 65);
            this.btnLista.TabIndex = 4;
            this.btnLista.Text = "Imprime Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // frm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 321);
            this.Controls.Add(this.btnLista);
            this.Name = "frm5";
            this.Text = "Formulário 5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLista;
    }
}