using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos.Entities
{
    public abstract class TaxPayer
    {
        public TaxPayer()
        {
        }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public string Name { get; set; }
        public double AnualIncome { get; set; }
    }
}
