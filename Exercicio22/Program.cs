using System;

namespace Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < valor; i++)
            {
                Console.WriteLine("Digite o primeiro peso: ");
                double peso1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo peso: ");
                double peso2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o terceiro peso: ");
                double peso3 = double.Parse(Console.ReadLine());

                double mediaPonderada = (peso1 * 2 + peso2 * 3 + peso3 * 5) / 10;

                Console.WriteLine(mediaPonderada.ToString("F1"));
            }
        }
    }
}
