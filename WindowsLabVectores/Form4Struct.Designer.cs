namespace WindowsLabVectores
{
    partial class Form4Struct
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
            this.btnPersonasEdades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonasEdades
            // 
            this.btnPersonasEdades.Location = new System.Drawing.Point(54, 118);
            this.btnPersonasEdades.Name = "btnPersonasEdades";
            this.btnPersonasEdades.Size = new System.Drawing.Size(405, 23);
            this.btnPersonasEdades.TabIndex = 0;
            this.btnPersonasEdades.Text = "Personas y edades";
            this.btnPersonasEdades.UseVisualStyleBackColor = true;
            this.btnPersonasEdades.Click += new System.EventHandler(this.btnPersonasEdades_Click);
            // 
            // Form4Struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPersonasEdades);
            this.Name = "Form4Struct";
            this.Text = "Form4Struct";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonasEdades;
    }
}