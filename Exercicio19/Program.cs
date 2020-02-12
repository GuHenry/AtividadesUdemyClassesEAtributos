using System;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    alcool++;
                }
                else if (codigo == 2)
                {
                    gasolina++;
                }
                else if (codigo == 3)
                {
                    diesel++;
                }
                codigo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
