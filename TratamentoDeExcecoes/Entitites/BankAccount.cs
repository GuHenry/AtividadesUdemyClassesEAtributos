using System;
using System.Collections.Generic;
using System.Text;
using TratamentoDeExcecoes.Expections;

namespace TratamentoDeExcecoes.Entitites
{
    public class BankAccount
    {
        public BankAccount()
        {

        }

        public BankAccount(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (Balance < amount)
                throw new DomainException("Not enough balance");
            if (WithDrawLimit < amount)
                throw new DomainException("The amount exceeds withdraw limit");
            Balance -= amount;
        }

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }
    }
}
