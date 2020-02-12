using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("Informe o raio: ");
            double raio = double.Parse(Console.ReadLine());

            double areaCirculo = pi * (raio + raio);

            Console.WriteLine($"Área do circulo: {areaCirculo.ToString("F4")}");
        }
    }
}
