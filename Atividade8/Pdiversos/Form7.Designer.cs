namespace Pdiversos
{
    partial class frm7
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
            this.btnNomes = new System.Windows.Forms.Button();
            this.lstbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNomes
            // 
            this.btnNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomes.Location = new System.Drawing.Point(90, 102);
            this.btnNomes.Name = "btnNomes";
            this.btnNomes.Size = new System.Drawing.Size(124, 65);
            this.btnNomes.TabIndex = 2;
            this.btnNomes.Text = "Lista Nomes";
            this.btnNomes.UseVisualStyleBackColor = true;
            this.btnNomes.Click += new System.EventHandler(this.btnNomes_Click);
            // 
            // lstbx
            // 
            this.lstbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbx.FormattingEnabled = true;
            this.lstbx.ItemHeight = 20;
            this.lstbx.Location = new System.Drawing.Point(243, 72);
            this.lstbx.Name = "lstbx";
            this.lstbx.Size = new System.Drawing.Size(361, 184);
            this.lstbx.TabIndex = 3;
            // 
            // frm7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 321);
            this.Controls.Add(this.lstbx);
            this.Controls.Add(this.btnNomes);
            this.Name = "frm7";
            this.Text = "Formulário 7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNomes;
        private System.Windows.Forms.ListBox lstbx;
    }
}