using System;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário em Lisarb: ");
            double salario = double.Parse(Console.ReadLine());
            double imposto = 0;
            if (salario >= 0 && salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000 && salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
                Console.WriteLine($"R$ {imposto.ToString("F2")}");
            }
            else if (salario > 3000 && salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
                Console.WriteLine($"R$ {imposto.ToString("F2")}");
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
                Console.WriteLine($"R$ {imposto.ToString("F2")}");
            }
        }
    }
}
