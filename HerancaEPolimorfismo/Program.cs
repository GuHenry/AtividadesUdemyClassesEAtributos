using HerancaEPolimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace HerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Product #{i}data: ");
                Console.WriteLine("Common, used or imported(c/u/i)?: ");
                char productType = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                if(productType == 'i')
                {
                    Console.WriteLine("Customns fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(productName, productPrice, customFee));
                }
                else if(productType == 'u')
                {
                    Console.WriteLine("Manufacture date(DD/MM/YYYY: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(productName, productPrice, date));
                }
                else
                {
                    products.Add(new Product(productName, productPrice));
                }
            }

            Console.WriteLine("Price Tags: ");
            foreach (var product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
