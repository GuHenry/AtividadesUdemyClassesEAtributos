using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo da peça: ");
            int codigoPeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças que você deseja: ");
            int numeroPeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da(s) peça(s): ");
            double valorPeca1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código da segunda peça: ");
            int codigoPeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças que você deseja: ");
            int numeroPeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digete o valor da(s) peça(s): ");
            double valorPeca2 = double.Parse(Console.ReadLine());

            double valorPagar = (numeroPeca1 * valorPeca1) + (numeroPeca2 * valorPeca2);
            Console.WriteLine($"Valor a pagar: {valorPagar.ToString("F2")}");
        }
    }
}
