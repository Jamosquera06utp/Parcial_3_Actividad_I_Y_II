namespace Parcial3.Actividad1
{
    public class Cuadrado : Figura
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea() => Lado * Lado;
        public override double CalcularPerimetro() => 4 * Lado;
    }
}