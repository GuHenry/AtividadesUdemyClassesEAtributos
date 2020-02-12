using AtividadesUdemyClassesEAtributos;
using System;

namespace Exercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("Digite um nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Digite o seu salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"{f.Nome}, ${f.SalarioLiquido()}");
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            f.Porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados atualizados: ${f.AumentarSalario()}");
        }
    }
}
