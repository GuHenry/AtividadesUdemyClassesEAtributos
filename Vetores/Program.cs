using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vetor = new Estudante[10];

            Console.WriteLine("Quantos quartos vão ser alugados: ");
            int numero = int.Parse(Console.ReadLine());
            for(int i = 0;i < numero;i++)
            {
                Console.WriteLine($"Aluguel #{i}: ");
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o quarto que você deseja: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("Quartos Alugados: ");
            for(int i=0;i < 10;i++)
            {
                if(vetor[i] != null)
                {
                    Console.WriteLine($"{i} : {vetor[i].Nome}, {vetor[i].Email}");
                }
            }
        }
    }
}
