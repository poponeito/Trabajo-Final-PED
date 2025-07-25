using System;
using System.Collections.Generic;
using System.Linq;

namespace BancoPreguntas
{
    public class Pregunta
    {
        public string PreguntaId { get; set; }
        public string Texto { get; set; }
        public List<string> Respuestas { get; set; }
        public int RespuestaCorrecta { get; set; }
        public string Asignatura { get; set; }
        public string Unidad { get; set; }
        public string SubUnidad { get; set; }

        public string ToFileString()
        {
            var respuestas = string.Join("|", Respuestas);
            return string.Join(";", PreguntaId, Texto.Replace(';', ' '), respuestas.Replace(';', ' '), RespuestaCorrecta, Asignatura, Unidad, SubUnidad);
        }

        public static Pregunta FromFileString(string line)
        {
            var parts = line.Split(';');
            return new Pregunta
            {
                PreguntaId = parts[0],
                Texto = parts[1],
                Respuestas = parts[2].Split('|').ToList(),
                RespuestaCorrecta = int.Parse(parts[3]),
                Asignatura = parts[4],
                Unidad = parts[5],
                SubUnidad = parts[6]
            };
        }

        public override string ToString()
        {
            return $"{Texto} ({Asignatura} - {Unidad}-{SubUnidad})";
        }
    }
}
