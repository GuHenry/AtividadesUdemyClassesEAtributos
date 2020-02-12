using System;

namespace Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de valores: ");
            int valor = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;
            for (int i = 0; i < valor; i++)
            {
                Console.WriteLine("Digite um numero: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                    dentro++;

                else
                    fora++;

            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
