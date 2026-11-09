namespace Parcial3.Actividad1
{
    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public Triangulo(double baseTri, double altura, double lado1, double lado2, double lado3)
        {
            Base = baseTri;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public override double CalcularArea() => (Base * Altura) / 2.0;
        public override double CalcularPerimetro() => Lado1 + Lado2 + Lado3;
    }
}