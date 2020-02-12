using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadesUdemyClassesEAtributos
{
    public class ConversorDeMoeda
    {
        public double Cotacao;
        public double Valor;
        public static double Iof = 6.0;
        
        public static double Conversao(double Cotacao, double Valor)
        {
            double total = Valor * Cotacao;
            return total + total * Iof / 100;
        }
    }
}
