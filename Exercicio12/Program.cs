using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade que você deseja: ");
            int quantidade = int.Parse(Console.ReadLine());
            double valor = 0;
            if (codigo == 1)
            {
                valor = 4 * quantidade;
            }
            else if (codigo == 2)
            {
                valor = 4.5 * quantidade;
            }
            else if (codigo == 3)
            {
                valor = 5 * quantidade;
            }
            else if (codigo == 4)
            {
                valor = 2 * quantidade;
            }
            else
            {
                valor = 1.5 * quantidade;
            }
            Console.WriteLine($"Valor da compra: R${valor.ToString("F2")}");
        }
    }
}
