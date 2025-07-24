using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BancoPreguntas
{
    public partial class FormPreguntas : Form
    {
        private const string FILE_NAME = "Preguntas.txt";

        public FormPreguntas()
        {
            InitializeComponent();
            CargarPreguntas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var p = new Pregunta
            {
                PreguntaId = Guid.NewGuid().ToString(),
                Texto = txtPregunta.Text,
                Respuestas = new List<string> { txtR1.Text, txtR2.Text, txtR3.Text, txtR4.Text },
                RespuestaCorrecta = int.Parse(txtCorrecta.Text),
                Asignatura = txtAsignatura.Text,
                Unidad = txtUnidad.Text,
                SubUnidad = txtSubUnidad.Text
            };
            File.AppendAllLines(FILE_NAME, new[] { p.ToFileString() });
            Limpiar();
            CargarPreguntas();
        }

        private void CargarPreguntas()
        {
            listPreguntas.Items.Clear();
            if (!File.Exists(FILE_NAME)) return;
            var lineas = File.ReadAllLines(FILE_NAME);
            foreach (var linea in lineas)
            {
                var p = Pregunta.FromFileString(linea);
                listPreguntas.Items.Add(p);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listPreguntas.SelectedItem == null) return;
            var p = (Pregunta)listPreguntas.SelectedItem;
            var lineas = File.ReadAllLines(FILE_NAME).ToList();
            lineas.RemoveAll(l => l.StartsWith(p.PreguntaId + ";"));
            File.WriteAllLines(FILE_NAME, lineas);
            CargarPreguntas();
        }

        private void Limpiar()
        {
            txtPregunta.Text = "";
            txtR1.Text = txtR2.Text = txtR3.Text = txtR4.Text = "";
            txtCorrecta.Text = "0";
            txtAsignatura.Text = txtUnidad.Text = txtSubUnidad.Text = "";
        }
    }
}
