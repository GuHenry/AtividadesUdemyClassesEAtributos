using System;

namespace Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int valor = int.Parse(Console.ReadLine());
            int nmr1 = 0;
            int nmr2 = 0;
            int calculo = nmr1 / nmr2;
            for (int i = 0; i < valor; i++)
            {
                Console.WriteLine("Digite um numero para divisão: ");
                nmr1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro numero para divisão: ");
                nmr2 = int.Parse(Console.ReadLine());
                if (nmr2 == 0)
                    Console.WriteLine("Divisão impossivel");
            }
        }
    }
}
