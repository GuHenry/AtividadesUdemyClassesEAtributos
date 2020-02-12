using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadesUdemySecao5
{
    public class ContaBanco
    {
        public ContaBanco(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        public ContaBanco(int numeroConta, string titular) 
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque + 5;
        }



        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
    }
}   
