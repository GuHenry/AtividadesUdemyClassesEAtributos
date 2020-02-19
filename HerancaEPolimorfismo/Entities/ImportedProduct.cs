using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo.Entities
{
    public class ImportedProduct : Product
    {
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name + "$" + TotalPrice() + "(" + CustomsFee + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public double CustomsFee { get; set; }
    }
}
