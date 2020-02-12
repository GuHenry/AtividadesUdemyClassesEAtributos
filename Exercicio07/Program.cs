using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor C: ");
            double c = double.Parse(Console.ReadLine());

            double pi = 3.14159;
            double areaTriangulo = (a * c) / 2;
            double areaCirculo = pi * (c * c);
            double areaTrapezio = (a + b) / 2 * c;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine($"Resultado da Área do triangulo: {areaTriangulo.ToString("F3")}");
            Console.WriteLine($"Resultado da Área do circulo: {areaCirculo.ToString("F3")}");
            Console.WriteLine($"Resultado da Área do trapezio: {areaTrapezio.ToString("F3")}");
            Console.WriteLine($"Resultado da Área do quadrado: {areaQuadrado.ToString("F3")}");
            Console.WriteLine($"Resultado da Área do retangulo: {areaRetangulo.ToString("F3")}");
        }
    }
}
