using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    public class Funcionario
    {
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem) 
        {
            Salario += Salario * porcentagem / 100;
        }

        public int Id { get;private set; }
        public string Nome { get; set; }
        public double Salario { get;private set; }


    }
}
