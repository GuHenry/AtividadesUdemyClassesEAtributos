using System;

namespace Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());
            int fatorial = 1;
            for (int i = 1; i <= valor; i++)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine($"Resultado: {fatorial} ");
        }
    }
}
