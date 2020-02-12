using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();
            Console.WriteLine("Digite a quantidade de alunos no Curso A: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("Digite o codigo dos alunos do curso A: ");
                int codigoA = int.Parse(Console.ReadLine());
                cursoA.Add(codigoA);
            }
            Console.WriteLine("Digite a quantidade de alunos no Curso B: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 1; i <= b; i++)
            {
                Console.WriteLine("Digite o codigo dos alunos do curso B: ");
                int codigoB = int.Parse(Console.ReadLine());
                cursoB.Add(codigoB);
            }
            Console.WriteLine("Digite a quantidade de alunos no Curso C: ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 1; i <= c; i++)
            {
                Console.WriteLine("Digite o codigo dos alunos do curso C: ");
                int codigoC = int.Parse(Console.ReadLine());
                cursoC.Add(codigoC);
            }

            cursoB.UnionWith(cursoC);
            cursoA.UnionWith(cursoB);
            int totalAluno = cursoA.Count;
            Console.WriteLine($"Total alunos: {totalAluno}");
        }
    }
}
