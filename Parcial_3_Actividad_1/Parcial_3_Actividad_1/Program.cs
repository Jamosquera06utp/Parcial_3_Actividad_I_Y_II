using System;

namespace Parcial3.Actividad1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Figura[] figuras = new Figura[]
            {
                new Rectangulo(5.0, 3.0),
                new Cuadrado(4.0),
                new Triangulo(6.0, 4.0, 6.0, 5.0, 5.0)
            };

            Console.WriteLine("--- RESULTADOS DE LAS FIGURAS GEOMÉTRICAS ---\n");
            foreach (Figura f in figuras)
            {
                Console.WriteLine($"Figura: {f.GetType().Name}");
                Console.WriteLine($"Área: {f.CalcularArea():F2}");
                Console.WriteLine($"Perímetro: {f.CalcularPerimetro():F2}");
                Console.WriteLine(new string('-', 45));
            }
        }
    }
}