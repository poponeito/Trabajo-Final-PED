namespace BancoPreguntas
{
    partial class FormPreguntas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listPreguntas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.TextBox txtR3;
        private System.Windows.Forms.TextBox txtR4;
        private System.Windows.Forms.TextBox txtCorrecta;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtSubUnidad;
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
            this.listPreguntas = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtR3 = new System.Windows.Forms.TextBox();
            this.txtR4 = new System.Windows.Forms.TextBox();
            this.txtCorrecta = new System.Windows.Forms.TextBox();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtSubUnidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listPreguntas
            // 
            this.listPreguntas.FormattingEnabled = true;
            this.listPreguntas.Location = new System.Drawing.Point(12, 12);
            this.listPreguntas.Name = "listPreguntas";
            this.listPreguntas.Size = new System.Drawing.Size(300, 420);
            this.listPreguntas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(330, 250);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(440, 250);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(330, 12);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(210, 60);
            this.txtPregunta.TabIndex = 3;
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(330, 78);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(210, 20);
            this.txtR1.TabIndex = 4;
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(330, 104);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(210, 20);
            this.txtR2.TabIndex = 5;
            // 
            // txtR3
            // 
            this.txtR3.Location = new System.Drawing.Point(330, 130);
            this.txtR3.Name = "txtR3";
            this.txtR3.Size = new System.Drawing.Size(210, 20);
            this.txtR3.TabIndex = 6;
            // 
            // txtR4
            // 
            this.txtR4.Location = new System.Drawing.Point(330, 156);
            this.txtR4.Name = "txtR4";
            this.txtR4.Size = new System.Drawing.Size(210, 20);
            this.txtR4.TabIndex = 7;
            // 
            // txtCorrecta
            // 
            this.txtCorrecta.Location = new System.Drawing.Point(330, 182);
            this.txtCorrecta.Name = "txtCorrecta";
            this.txtCorrecta.Size = new System.Drawing.Size(210, 20);
            this.txtCorrecta.TabIndex = 8;
            this.txtCorrecta.Text = "0";
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Location = new System.Drawing.Point(330, 208);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(210, 20);
            this.txtAsignatura.TabIndex = 9;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(330, 234);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(210, 20);
            this.txtUnidad.TabIndex = 10;
            // 
            // txtSubUnidad
            // 
            this.txtSubUnidad.Location = new System.Drawing.Point(330, 260);
            this.txtSubUnidad.Name = "txtSubUnidad";
            this.txtSubUnidad.Size = new System.Drawing.Size(210, 20);
            this.txtSubUnidad.TabIndex = 11;
            // 
            // FormPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.txtSubUnidad);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtAsignatura);
            this.Controls.Add(this.txtCorrecta);
            this.Controls.Add(this.txtR4);
            this.Controls.Add(this.txtR3);
            this.Controls.Add(this.txtR2);
            this.Controls.Add(this.txtR1);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listPreguntas);
            this.Name = "FormPreguntas";
            this.Text = "Preguntas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
