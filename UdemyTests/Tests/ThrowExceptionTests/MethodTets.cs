using FluentAssertions;
using System;
using TratamentoDeExcecoes.Entitites;
using TratamentoDeExcecoes.Expections;
using Xunit;

namespace UdemyTests
{
    public class MethodTets
    {
        [Fact]
        public void deve_depositar_na_conta()
        {
            BankAccount acc = new BankAccount(01, "conta", 200, 100);

            double deposit = 200;

            acc.Deposit(deposit);

            acc.Balance.Should().Be(400);
        }

        [Fact]
        public void deve_fazer_saque()
        {
            BankAccount acc = new BankAccount(02, "conta2", 300, 500);
            double withdraw = 100;

            acc.WithDraw(withdraw);
            acc.Balance.Should().Be(200);
        }

        [Fact]
        public void nao_deve_sacar_se_o_valor_for_maior_que_limite_de_saque()
        {
            BankAccount account = new BankAccount(02, "conta2", 300, 50);

            double withdraw = 100;

            Action acc = () => account.WithDraw(withdraw);

            acc.Should().Throw<DomainException>().WithMessage("The amount exceeds withdraw limit");

        }
        
        [Fact]
        public void nao_deve_sacar_se_nao_tiver_saldo_na_conta()
        {
            BankAccount account = new BankAccount(02, "conta2", 50, 200);

            double withdraw = 100;

            Action acc = () => account.WithDraw(withdraw);

            acc.Should().Throw<DomainException>().WithMessage("Not enough balance");

        }

    }
}
