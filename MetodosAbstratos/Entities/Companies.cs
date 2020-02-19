using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos.Entities
{
    class Companies : TaxPayer
    {
        public Companies(string name, double anualIncome, int employes) : base(name,anualIncome)
        {
            Employes = employes;
        }

        public override double Tax()
        {
            if (Employes > 10)
                return AnualIncome * 0.14;
            else
                return AnualIncome * 0.16;
        }
        public int Employes { get; set; }
    }
}
