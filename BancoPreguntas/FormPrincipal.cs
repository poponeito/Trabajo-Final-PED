using System.Windows.Forms;

namespace BancoPreguntas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mnuPreguntas_Click(object sender, System.EventArgs e)
        {
            using (var f = new FormPreguntas())
            {
                f.ShowDialog();
            }
        }

        private void mnuGenerarExamen_Click(object sender, System.EventArgs e)
        {
            using (var f = new FormGenerarExamen())
            {
                f.ShowDialog();
            }
        }

        private void mnuCorregirExamen_Click(object sender, System.EventArgs e)
        {
            using (var f = new FormCorregirExamen())
            {
                f.ShowDialog();
            }
        }
    }
}
