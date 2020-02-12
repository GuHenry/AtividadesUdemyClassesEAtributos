using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora de inicio da partida");
            int horaInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora do fim da partida");
            int horaFim = int.Parse(Console.ReadLine());

            int dia = 24;
            int horas;
            if (horaInicio < horaFim)
            {
                horas = horaFim - horaInicio;
            }
            else
            {
                horas = dia - horaInicio + horaFim;
            }

            Console.WriteLine($"A duração do jogo foi de {horas} horas");
        }
    }
}
