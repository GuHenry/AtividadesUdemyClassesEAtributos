using System;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de X: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y: ");
            double y = double.Parse(Console.ReadLine());

            while (x != 0 || y != 0)
            {
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
                Console.WriteLine("Digite o valor de X: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Y: ");
                y = double.Parse(Console.ReadLine());
            }
        }
    }
}
