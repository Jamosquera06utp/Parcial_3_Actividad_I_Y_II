namespace JsonDemo
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }

        public Persona(string nombre, int edad, string carrera)
        {
            Nombre = nombre;
            Edad = edad;
            Carrera = carrera;
        }
    }
}