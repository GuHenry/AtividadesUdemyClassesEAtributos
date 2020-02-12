using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());
            if (valor >= 0 && valor <= 25)
            {
                Console.WriteLine("Valor entre 0 e 25");
            }
            else if (valor >= 25 && valor <= 50)
            {
                Console.WriteLine("Valor entre 25 e 50");
            }
            else if (valor >= 50 && valor <= 75)
            {
                Console.WriteLine("Valor entre 50 e 75");
            }
            else if (valor >= 75 && valor <= 100)
            {
                Console.WriteLine("Valor entre 75 e 100");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
