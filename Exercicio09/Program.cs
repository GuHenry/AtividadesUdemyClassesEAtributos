using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int nmr = int.Parse(Console.ReadLine());

            if (nmr % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");
        }
    }
}
