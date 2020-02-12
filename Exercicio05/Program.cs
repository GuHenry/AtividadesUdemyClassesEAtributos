using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do funcionário: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas trabalhadas: ");
            int numeroHoraTrabalhada = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora trabalhada: ");
            double valorHora = double.Parse(Console.ReadLine());
            double salario = numeroHoraTrabalhada * valorHora;
            Console.WriteLine($"Numero: {numeroFuncionario}");
            Console.WriteLine($"Salário: {salario.ToString("F2")}");
        }
    }
}
