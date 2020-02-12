using System;

namespace Exercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero : ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    numero = numero / i;
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
