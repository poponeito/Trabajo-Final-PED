using System;
using System.Collections.Generic;
using System.Linq;

namespace BancoPreguntas
{
    public class Examen
    {
        public string ExamenId { get; set; }
        public DateTime Fecha { get; set; }
        public string Asignatura { get; set; }
        public List<string> PreguntaIds { get; set; }

        public string ToFileString()
        {
            return string.Join(";", ExamenId, Fecha.ToString("yyyy-MM-dd"), Asignatura, string.Join("|", PreguntaIds));
        }

        public static Examen FromFileString(string line)
        {
            var parts = line.Split(';');
            return new Examen
            {
                ExamenId = parts[0],
                Fecha = DateTime.Parse(parts[1]),
                Asignatura = parts[2],
                PreguntaIds = parts.Length > 3 ? parts[3].Split('|').ToList() : new List<string>()
            };
        }
    }
}
