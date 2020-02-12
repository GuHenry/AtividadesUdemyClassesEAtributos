using AtividadesUdemyClassesEAtributos;
using System;

namespace ExercicioFixacaoMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda moeda = new ConversorDeMoeda();

            Console.WriteLine("Digite a cotação do dolar atual: ");
            moeda.Cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de doláres a comprar: ");
            moeda.Valor = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais: {ConversorDeMoeda.Conversao(moeda.Cotacao, moeda.Valor).ToString("F2")}");
        }
    }
}
