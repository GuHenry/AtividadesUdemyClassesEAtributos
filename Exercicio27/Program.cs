using AtividadesUdemyClassesEAtributos;
using System;

namespace Exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            if (p1.Idade > p2.Idade)
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            else
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
        }
    }
}
