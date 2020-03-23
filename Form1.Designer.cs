namespace SIUUUUU
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtMesagge = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "DALE PZZZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMesagge
            // 
            this.txtMesagge.AutoSize = true;
            this.txtMesagge.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesagge.Location = new System.Drawing.Point(147, 87);
            this.txtMesagge.Name = "txtMesagge";
            this.txtMesagge.Size = new System.Drawing.Size(539, 55);
            this.txtMesagge.TabIndex = 1;
            this.txtMesagge.Text = "Dale click al boton Ojete";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(457, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 94);
            this.button4.TabIndex = 4;
            this.button4.Text = "dale plox";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtMesagge);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtMesagge;
        private System.Windows.Forms.Button button4;
    }
}

