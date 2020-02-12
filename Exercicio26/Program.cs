using System;

namespace Exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                int linha = i;
                int quadrado = i * i;
                int cubo = i * i * i;
                Console.WriteLine($"{linha}, {quadrado}, {cubo}");
            }
        }
    }
}
