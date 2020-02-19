using HerancaEPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo.Entities
{
    public class UsedProduct : Product
    {
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + "(used)" + "$" + Price + ManufactureDate;
        }

        public DateTime ManufactureDate { get; set; }
    }
}
