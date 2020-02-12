using System;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;

            Console.WriteLine($"Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro : {idade} anos de idade, código {codigo} e gênero: {genero}");
        }
    }
}
