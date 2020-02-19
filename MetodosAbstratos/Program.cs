using MetodosAbstratos.Entities;
using System;
using System.Collections.Generic;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> taxPayers = new List<TaxPayer>();
            Console.WriteLine("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.WriteLine("Individual or company(i/c)?: ");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Anual income: ");
                double income = double.Parse(Console.ReadLine());
                if(type == 'i')
                {
                    Console.WriteLine("Health Expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(name, income, healthExpenditure));
                }
                else
                {
                    Console.WriteLine("Number of employes: ");
                    int employes = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Companies(name, income, employes));
                }
                double sum = 0;
                Console.WriteLine("Taxes paid: ");
                foreach (var payer in taxPayers)
                {
                    double tax = payer.Tax();
                    Console.WriteLine($"{payer.Name}, ${payer.Tax()} ");
                    sum += tax;
                }
                Console.WriteLine($"Total taxes: ${sum}");
            }
        }
    }
}
