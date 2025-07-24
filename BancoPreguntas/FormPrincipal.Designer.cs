namespace BancoPreguntas
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPreguntas;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerarExamen;
        private System.Windows.Forms.ToolStripMenuItem mnuCorregirExamen;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuPreguntas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerarExamen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCorregirExamen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPreguntas,
            this.mnuGenerarExamen,
            this.mnuCorregirExamen});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuPreguntas
            // 
            this.mnuPreguntas.Name = "mnuPreguntas";
            this.mnuPreguntas.Size = new System.Drawing.Size(71, 20);
            this.mnuPreguntas.Text = "Preguntas";
            this.mnuPreguntas.Click += new System.EventHandler(this.mnuPreguntas_Click);
            // 
            // mnuGenerarExamen
            // 
            this.mnuGenerarExamen.Name = "mnuGenerarExamen";
            this.mnuGenerarExamen.Size = new System.Drawing.Size(108, 20);
            this.mnuGenerarExamen.Text = "Generar Examen";
            this.mnuGenerarExamen.Click += new System.EventHandler(this.mnuGenerarExamen_Click);
            // 
            // mnuCorregirExamen
            // 
            this.mnuCorregirExamen.Name = "mnuCorregirExamen";
            this.mnuCorregirExamen.Size = new System.Drawing.Size(111, 20);
            this.mnuCorregirExamen.Text = "Corregir Examen";
            this.mnuCorregirExamen.Click += new System.EventHandler(this.mnuCorregirExamen_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Banco de Preguntas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
