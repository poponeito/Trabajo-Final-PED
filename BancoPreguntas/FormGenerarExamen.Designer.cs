namespace BancoPreguntas
{
    partial class FormGenerarExamen
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Button btnGenerar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Location = new System.Drawing.Point(12, 12);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(260, 20);
            this.txtAsignatura.TabIndex = 0;
            this.txtAsignatura.PlaceholderText = "Asignatura";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(12, 38);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(260, 20);
            this.txtUnidades.TabIndex = 1;
            this.txtUnidades.PlaceholderText = "Unidades (separadas por coma)";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(12, 64);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(260, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // FormGenerarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.txtAsignatura);
            this.Name = "FormGenerarExamen";
            this.Text = "Generar Examen";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
