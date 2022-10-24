namespace WindowsLabVectores
{
    partial class Form2
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
            this.lblPrecios = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrecios
            // 
            this.lblPrecios.AutoSize = true;
            this.lblPrecios.Location = new System.Drawing.Point(107, 86);
            this.lblPrecios.Name = "lblPrecios";
            this.lblPrecios.Size = new System.Drawing.Size(199, 16);
            this.lblPrecios.TabIndex = 0;
            this.lblPrecios.Text = "Ingrese el precio de 8 productos";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(119, 132);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(176, 23);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "Mostrar la suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lblPrecios);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecios;
        private System.Windows.Forms.Button btnSuma;
    }
}