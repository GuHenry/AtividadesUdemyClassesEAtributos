using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo.Entities
{
    public class Product
    {
        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + "$" + Price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
