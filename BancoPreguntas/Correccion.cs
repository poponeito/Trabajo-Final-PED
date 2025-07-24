namespace BancoPreguntas
{
    public class Correccion
    {
        public string ExamenId { get; set; }
        public string Alumno { get; set; }
        public int Puntaje { get; set; }

        public string ToFileString()
        {
            return string.Join(";", ExamenId, Alumno, Puntaje);
        }

        public static Correccion FromFileString(string line)
        {
            var parts = line.Split(';');
            return new Correccion
            {
                ExamenId = parts[0],
                Alumno = parts[1],
                Puntaje = int.Parse(parts[2])
            };
        }
    }
}
