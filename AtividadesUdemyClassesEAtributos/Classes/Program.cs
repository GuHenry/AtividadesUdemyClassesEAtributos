using AtividadesUdemyClassesEAtributos.Classes;
using System;

namespace AtividadesUdemyClassesEAtributos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Digite o nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.WriteLine("Digite a idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.WriteLine("Digite a idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());
            //if(p1.Idade > p2.Idade)
            //    Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            //else
            //    Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            /*----------------------------------------------------------------------------------------------------------------*/
            //Funcionario f1 = new Funcionario();
            //Funcionario f2 = new Funcionario();

            //Console.WriteLine("Digite o nome do funcionario: ");
            //f1.Nome = Console.ReadLine();
            //Console.WriteLine("Digite seu salário: ");
            //f1.Salario = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o nome do funcionario: ");
            //f2.Nome = Console.ReadLine();
            //Console.WriteLine("Digite seu salário: ");
            //f2.Salario = decimal.Parse(Console.ReadLine());

            //decimal media = (f1.Salario + f2.Salario) / 2;

            //Console.WriteLine($"Media: {media}");
            /*----------------------------------------------------------------------------------------------------------------*/
            //Retangulo ret = new Retangulo();

            //Console.WriteLine("Digite a largura: ");
            //ret.Largura = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a altura: ");
            //ret.Altura = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Area: {ret.Area()}");
            //Console.WriteLine($"Perimetro: {ret.Perimetro()}");
            //Console.WriteLine($"Diagonal: {ret.Diagonal()}");
            /*----------------------------------------------------------------------------------------------------------------*/
            //Funcionario f = new Funcionario();
            //Console.WriteLine("Digite um nome: ");
            //f.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o seu salário bruto: ");
            //f.SalarioBruto = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o imposto: ");
            //f.Imposto = double.Parse(Console.ReadLine());

            //Console.WriteLine($"{f.Nome}, ${f.SalarioLiquido()}");
            //Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            //f.Porcentagem = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Dados atualizados: ${f.AumentarSalario()}");
            /*----------------------------------------------------------------------------------------------------------------*/
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
            if(aluno1.NotaFinal() < 60)
            {
                Console.WriteLine(aluno1.Restante());
            }
        }
    }
}

