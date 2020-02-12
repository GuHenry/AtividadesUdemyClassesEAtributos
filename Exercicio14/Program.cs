using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de X : ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y : ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}
