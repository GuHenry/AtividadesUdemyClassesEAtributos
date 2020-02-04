using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadesUdemyClassesEAtributos
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Falta;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Aprovacao()
        {
            if (NotaFinal() >= 60)
                return "Aprovado";
            else
                return "Reprovado";
        }

        public double Restante()
        {
            if(NotaFinal() < 60)
            {
                Falta = 60 - NotaFinal() ;
            }
            return Falta;

        }


    }
}
