using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
                Console.WriteLine("Negativo");
            else
                Console.WriteLine("Não negativo");
        }
    }
}
