using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para C: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);

            Console.WriteLine($"Diferença: {diferenca}");
        }
    }
}
