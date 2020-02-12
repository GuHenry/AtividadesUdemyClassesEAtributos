using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de linhas: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de colunas: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                string[] indice = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = int.Parse(indice[j]);
                }
            }
            Console.WriteLine("Digite o número que deseja analisar: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if(matriz[i,j] == numero)
                    {
                        Console.WriteLine($"Posições: {i} , {j} respectivamente:");
                        if(i > 0)
                            Console.WriteLine($"Cima: {matriz[i - 1, j]}");
                        if(j > 0)
                            Console.WriteLine($"Esquerda: {matriz[i, j -1]}");
                        if(j < colunas - 1)
                            Console.WriteLine($"Direita: {matriz[i,j + 1]}");
                        if(i < linhas - 1)
                            Console.WriteLine($"Baixo: {matriz[i + 1, j]}");
                    }
                }
            }

        }
    }
}
