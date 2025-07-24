using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BancoPreguntas
{
    public partial class FormCorregirExamen : Form
    {
        private const string FILE_PREGUNTAS = "Preguntas.txt";
        private const string FILE_EXAMENES = "Examenes.txt";
        private const string FILE_CORRECCIONES = "Correcciones.txt";

        public FormCorregirExamen()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            listPreguntas.Items.Clear();
            if (!File.Exists(FILE_EXAMENES) || !File.Exists(FILE_PREGUNTAS)) return;

            var examen = File.ReadAllLines(FILE_EXAMENES)
                .Select(Examen.FromFileString)
                .FirstOrDefault(x => x.ExamenId == txtExamenId.Text);
            if (examen == null)
            {
                MessageBox.Show("Examen no encontrado");
                return;
            }
            var preguntas = File.ReadAllLines(FILE_PREGUNTAS)
                .Select(Pregunta.FromFileString)
                .Where(p => examen.PreguntaIds.Contains(p.PreguntaId))
                .ToList();
            foreach (var p in preguntas)
            {
                listPreguntas.Items.Add(p);
            }
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            if (listPreguntas.Items.Count == 0) return;
            var respuestas = txtRespuestas.Text.Split(',').Select(r => int.Parse(r.Trim())).ToList();
            var preguntas = listPreguntas.Items.Cast<Pregunta>().ToList();
            int correctas = 0;
            for (int i = 0; i < preguntas.Count && i < respuestas.Count; i++)
            {
                if (preguntas[i].RespuestaCorrecta == respuestas[i]) correctas++;
            }
            var total = preguntas.Count;
            var puntaje = correctas * 100 / total;
            MessageBox.Show($"Puntaje: {puntaje}");
            var correccion = new Correccion
            {
                ExamenId = txtExamenId.Text,
                Alumno = txtAlumno.Text,
                Puntaje = puntaje
            };
            File.AppendAllLines(FILE_CORRECCIONES, new[] { correccion.ToFileString() });
        }
    }
}
