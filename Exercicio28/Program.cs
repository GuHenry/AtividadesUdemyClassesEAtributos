using AtividadesUdemyClassesEAtributos;
using System;

namespace Exercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Digite o nome do funcionario: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu salário: ");
            f1.Salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do funcionario: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu salário: ");
            f2.Salario = decimal.Parse(Console.ReadLine());

            decimal media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine($"Media: {media}");
        }
    }
}
