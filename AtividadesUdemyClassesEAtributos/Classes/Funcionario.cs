using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadesUdemyClassesEAtributos
{
    public class Funcionario
    {
        public string Nome;
        public decimal Salario;
        public double SalarioBruto;
        public double Imposto;
        public double Porcentagem;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario()
        {
            return (Porcentagem * SalarioBruto) + SalarioLiquido();
        }
    }
}
