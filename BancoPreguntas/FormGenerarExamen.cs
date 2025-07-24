using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BancoPreguntas
{
    public partial class FormGenerarExamen : Form
    {
        private const string FILE_PREGUNTAS = "Preguntas.txt";
        private const string FILE_EXAMENES = "Examenes.txt";
        private const string FILE_IMPRESION = "ImpresionExamen.txt";

        public FormGenerarExamen()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FILE_PREGUNTAS))
            {
                MessageBox.Show("No hay preguntas cargadas");
                return;
            }
            var asignatura = txtAsignatura.Text;
            var unidades = txtUnidades.Text.Split(',').Select(u => u.Trim()).ToList();

            var lineas = File.ReadAllLines(FILE_PREGUNTAS);
            var preguntas = lineas.Select(Pregunta.FromFileString)
                .Where(p => p.Asignatura.Equals(asignatura, StringComparison.OrdinalIgnoreCase)
                    && unidades.Contains(p.Unidad))
                .GroupBy(p => p.SubUnidad)
                .Select(g => g.OrderBy(_ => Guid.NewGuid()).First())
                .ToList();

            var examenId = Guid.NewGuid().ToString();
            var examen = new Examen
            {
                ExamenId = examenId,
                Fecha = DateTime.Now,
                Asignatura = asignatura,
                PreguntaIds = preguntas.Select(p => p.PreguntaId).ToList()
            };

            File.AppendAllLines(FILE_EXAMENES, new[] { examen.ToFileString() });

            using (var sw = new StreamWriter(FILE_IMPRESION))
            {
                sw.WriteLine($"Examen ID: {examenId}");
                sw.WriteLine($"Fecha: {examen.Fecha:dd/MM/yyyy}");
                sw.WriteLine($"Asignatura: {asignatura}");
                sw.WriteLine();
                int i = 1;
                foreach (var p in preguntas)
                {
                    sw.WriteLine($"{i}. {p.Texto}");
                    for (int j = 0; j < p.Respuestas.Count; j++)
                    {
                        sw.WriteLine($"   {j + 1}) {p.Respuestas[j]}");
                    }
                    sw.WriteLine();
                    i++;
                }
            }

            MessageBox.Show($"Examen generado con ID {examenId}");
            this.Close();
        }
    }
}
