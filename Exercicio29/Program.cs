using AtividadesUdemyClassesEAtributos.Classes;
using System;

namespace Exercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Digite a largura: ");
            ret.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area: {ret.Area()}");
            Console.WriteLine($"Perimetro: {ret.Perimetro()}");
            Console.WriteLine($"Diagonal: {ret.Diagonal()}");
        }
    }
}
