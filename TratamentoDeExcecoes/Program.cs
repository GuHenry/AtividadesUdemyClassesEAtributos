using System;
using System.Collections.Generic;
using TratamentoDeExcecoes.Entitites;
using TratamentoDeExcecoes.Expections;
using Xunit;

namespace TratamentoDeExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount acc = new BankAccount();
                Console.WriteLine("Number: ");
                acc.Number = int.Parse(Console.ReadLine());
                Console.WriteLine("Holder: ");
                acc.Holder = Console.ReadLine();
                Console.WriteLine("Initital Balance: ");
                acc.Balance = double.Parse(Console.ReadLine());
                Console.WriteLine("Withdraw Limit: ");
                acc.WithDrawLimit = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                acc.WithDraw(amount);
                Console.WriteLine($"New Balance: {acc.Balance}");
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw Error: " + e.Message);
            }


        }
    }
}
