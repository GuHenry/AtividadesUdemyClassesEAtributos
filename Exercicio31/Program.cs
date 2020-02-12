using AtividadesUdemyClassesEAtributos;
using System;

namespace Exercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a nota do primeiro trimestre: ");
            aluno1.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do primeiro trimestre: ");
            aluno1.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do primeiro trimestre: ");
            aluno1.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nota final: {aluno1.NotaFinal()}");
            Console.WriteLine($"{aluno1.Aprovacao()}");
            if (aluno1.NotaFinal() < 60)
            {
                Console.WriteLine(aluno1.Restante());
            }
        }
    }
}
