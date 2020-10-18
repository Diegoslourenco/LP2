namespace Pmetodos
{
    partial class frmExercicio3
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
            this.btnInverter = new System.Windows.Forms.Button();
            this.btnRemover2 = new System.Windows.Forms.Button();
            this.btnRemover1 = new System.Windows.Forms.Button();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInverter
            // 
            this.btnInverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverter.Location = new System.Drawing.Point(359, 188);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(100, 78);
            this.btnInverter.TabIndex = 13;
            this.btnInverter.Text = "Inverte a palavra";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // btnRemover2
            // 
            this.btnRemover2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover2.Location = new System.Drawing.Point(193, 188);
            this.btnRemover2.Name = "btnRemover2";
            this.btnRemover2.Size = new System.Drawing.Size(141, 78);
            this.btnRemover2.TabIndex = 12;
            this.btnRemover2.Text = "Remover primeiro do segundo (Replace)";
            this.btnRemover2.UseVisualStyleBackColor = true;
            this.btnRemover2.Click += new System.EventHandler(this.btnRemover2_Click);
            // 
            // btnRemover1
            // 
            this.btnRemover1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover1.Location = new System.Drawing.Point(39, 188);
            this.btnRemover1.Name = "btnRemover1";
            this.btnRemover1.Size = new System.Drawing.Size(106, 78);
            this.btnRemover1.TabIndex = 11;
            this.btnRemover1.Text = "Remover primeiro do segundo";
            this.btnRemover1.UseVisualStyleBackColor = true;
            this.btnRemover1.Click += new System.EventHandler(this.btnRemover1_Click);
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra2.Location = new System.Drawing.Point(71, 102);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra2.TabIndex = 10;
            this.lblPalavra2.Text = "Palavra 2";
            this.lblPalavra2.Click += new System.EventHandler(this.lblPalavra2_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra1.Location = new System.Drawing.Point(71, 26);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra1.TabIndex = 9;
            this.lblPalavra1.Text = "Palavra 1";
            this.lblPalavra1.Click += new System.EventHandler(this.lblPalavra1_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra2.Location = new System.Drawing.Point(228, 96);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(231, 26);
            this.txtPalavra2.TabIndex = 8;
            this.txtPalavra2.TextChanged += new System.EventHandler(this.txtPalavra2_TextChanged);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra1.Location = new System.Drawing.Point(228, 26);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(231, 26);
            this.txtPalavra1.TabIndex = 7;
            this.txtPalavra1.TextChanged += new System.EventHandler(this.txtPalavra1_TextChanged);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 292);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnRemover2);
            this.Controls.Add(this.btnRemover1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button btnRemover2;
        private System.Windows.Forms.Button btnRemover1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
    }
}