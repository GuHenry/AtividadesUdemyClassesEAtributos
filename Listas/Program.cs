using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> f = new List<Funcionario>();
            Console.WriteLine("Quantos funcionários serão registrados?: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Digite o Id que será registrado: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do funcionario: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o salario do funcionario: ");
                double salario = double.Parse(Console.ReadLine());
                f.Add(new Funcionario(id, nome, salario));
            }
            Console.WriteLine("Coloque o Id do funcionario que deseja aumentar o salário: ");
            int idPesquisa = int.Parse(Console.ReadLine());

            Funcionario pesquisa = f.Find(d => d.Id == idPesquisa);
            if(pesquisa != null)
            {
                Console.WriteLine("Qual a porcentagem do aumento?: ");
                double porcentagem = double.Parse(Console.ReadLine());
                pesquisa.AumentoSalario(porcentagem);
            }else
                Console.WriteLine("Id inexistente");
            Console.WriteLine("Lista de funcionarios: ");
            foreach (Funcionario funcionarios in f)
            {
                Console.WriteLine($"Id:{funcionarios.Id}, Nome:{funcionarios.Nome}, Salário:{funcionarios.Salario}");
            }
        }
    }
}
