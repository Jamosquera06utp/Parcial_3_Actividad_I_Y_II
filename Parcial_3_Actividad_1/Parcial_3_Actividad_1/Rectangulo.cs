namespace Parcial3.Actividad1
{
    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double baseRect, double altura)
        {
            Base = baseRect;
            Altura = altura;
        }

        public override double CalcularArea() => Base * Altura;
        public override double CalcularPerimetro() => 2 * (Base + Altura);
    }
}