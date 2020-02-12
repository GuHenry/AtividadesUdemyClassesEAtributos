using System;

namespace AtividadesUdemySecao5
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaBanco conta;

            Console.WriteLine("Digite o Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Deseja fazer um deposito inicial ?(Sim/Não)");
            string condicao = Console.ReadLine();
            if (condicao == "Sim")
            {
                Console.WriteLine("Digite o valor do deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBanco(numeroConta, nome, depositoInicial);
            }
            else
                conta = new ContaBanco(numeroConta, nome);
            

            Console.WriteLine($"Conta: {conta.NumeroConta} ,Titular: {conta.Titular}, Saldo: ${conta.Saldo} ");
            Console.WriteLine("Insira um valor para deposito: ");
            double valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);
            Console.WriteLine($"Conta: {conta.NumeroConta} ,Titular: {conta.Titular}, Saldo: ${conta.Saldo} ");
            Console.WriteLine("Insira o valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine($"Conta: {conta.NumeroConta} ,Titular: {conta.Titular}, Saldo: ${conta.Saldo} ");

        }
    }
}
