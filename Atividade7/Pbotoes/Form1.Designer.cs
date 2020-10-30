namespace Pbotoes
{
    partial class frm1
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnEspacos = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnLetraRepetida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtTexto.Location = new System.Drawing.Point(44, 30);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(336, 96);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnEspacos
            // 
            this.btnEspacos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspacos.Location = new System.Drawing.Point(113, 141);
            this.btnEspacos.Name = "btnEspacos";
            this.btnEspacos.Size = new System.Drawing.Size(189, 33);
            this.btnEspacos.TabIndex = 1;
            this.btnEspacos.Text = "Número de espaços";
            this.btnEspacos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspacos.UseVisualStyleBackColor = true;
            this.btnEspacos.Click += new System.EventHandler(this.btnEspacos_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetraR.Location = new System.Drawing.Point(113, 180);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(189, 33);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Número Letra R";
            this.btnLetraR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnLetraRepetida
            // 
            this.btnLetraRepetida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetraRepetida.Location = new System.Drawing.Point(113, 219);
            this.btnLetraRepetida.Name = "btnLetraRepetida";
            this.btnLetraRepetida.Size = new System.Drawing.Size(189, 33);
            this.btnLetraRepetida.TabIndex = 3;
            this.btnLetraRepetida.Text = "Número Letra Repetida";
            this.btnLetraRepetida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLetraRepetida.UseVisualStyleBackColor = true;
            this.btnLetraRepetida.Click += new System.EventHandler(this.btnLetraRepetida_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 263);
            this.Controls.Add(this.btnLetraRepetida);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnEspacos);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frm1";
            this.Text = "Form 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnEspacos;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnLetraRepetida;
    }
}