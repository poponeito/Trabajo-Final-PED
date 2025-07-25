namespace BancoPreguntas
{
    partial class FormCorregirExamen
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtExamenId;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox listPreguntas;
        private System.Windows.Forms.TextBox txtRespuestas;
        private System.Windows.Forms.Button btnCorregir;
        private System.Windows.Forms.TextBox txtAlumno;

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
            this.txtExamenId = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.listPreguntas = new System.Windows.Forms.ListBox();
            this.txtRespuestas = new System.Windows.Forms.TextBox();
            this.btnCorregir = new System.Windows.Forms.Button();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtExamenId
            // 
            this.txtExamenId.Location = new System.Drawing.Point(12, 12);
            this.txtExamenId.Name = "txtExamenId";
            this.txtExamenId.Size = new System.Drawing.Size(200, 20);
            this.txtExamenId.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(218, 10);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // listPreguntas
            // 
            this.listPreguntas.FormattingEnabled = true;
            this.listPreguntas.Location = new System.Drawing.Point(12, 38);
            this.listPreguntas.Name = "listPreguntas";
            this.listPreguntas.Size = new System.Drawing.Size(360, 147);
            this.listPreguntas.TabIndex = 2;
            // 
            // txtRespuestas
            // 
            this.txtRespuestas.Location = new System.Drawing.Point(12, 191);
            this.txtRespuestas.Name = "txtRespuestas";
            this.txtRespuestas.Size = new System.Drawing.Size(360, 20);
            this.txtRespuestas.TabIndex = 3;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(12, 217);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(360, 20);
            this.txtAlumno.TabIndex = 4;
            // 
            // btnCorregir
            // 
            this.btnCorregir.Location = new System.Drawing.Point(12, 243);
            this.btnCorregir.Name = "btnCorregir";
            this.btnCorregir.Size = new System.Drawing.Size(360, 23);
            this.btnCorregir.TabIndex = 5;
            this.btnCorregir.Text = "Corregir";
            this.btnCorregir.UseVisualStyleBackColor = true;
            this.btnCorregir.Click += new System.EventHandler(this.btnCorregir_Click);
            // 
            // FormCorregirExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 278);
            this.Controls.Add(this.btnCorregir);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.txtRespuestas);
            this.Controls.Add(this.listPreguntas);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtExamenId);
            this.Name = "FormCorregirExamen";
            this.Text = "Corregir Examen";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
