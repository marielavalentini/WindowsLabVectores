namespace WindowsLabVectores
{
    partial class Form5Struct
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
            this.btnCiudadesTemperaturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCiudadesTemperaturas
            // 
            this.btnCiudadesTemperaturas.Location = new System.Drawing.Point(112, 99);
            this.btnCiudadesTemperaturas.Name = "btnCiudadesTemperaturas";
            this.btnCiudadesTemperaturas.Size = new System.Drawing.Size(252, 23);
            this.btnCiudadesTemperaturas.TabIndex = 0;
            this.btnCiudadesTemperaturas.Text = "Ciudades y Temperaturas";
            this.btnCiudadesTemperaturas.UseVisualStyleBackColor = true;
            this.btnCiudadesTemperaturas.Click += new System.EventHandler(this.btnCiudadesTemperaturas_Click);
            // 
            // Form5Struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCiudadesTemperaturas);
            this.Name = "Form5Struct";
            this.Text = "Form5Struct";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCiudadesTemperaturas;
    }
}