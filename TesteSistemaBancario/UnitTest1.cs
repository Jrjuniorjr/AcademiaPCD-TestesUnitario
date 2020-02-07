using NUnit.Framework;
using SistemaBancario.model;

namespace TesteSistemaBancario
{
    public class Tests
    {
        public Conta conta;
        [SetUp]
        public void Setup()
        {
            conta = new Conta(0, "000000000000");
        }

        [Test]
        public void Creditar()
        {
            conta.Creditar(50);
            Assert.AreEqual(50, conta.Saldo);
        }
        [Test]
        public void DebitarSemSaldoSuficiente()
        {
            conta.Creditar(30);
            conta.Debitar(50);
            Assert.AreEqual(30, conta.Saldo);
        }

        [Test]
        public void DebitarComSaldoIgual()
        {
            conta.Creditar(50);
            conta.Debitar(50);
            Assert.AreEqual(0, conta.Saldo);
        }

        [Test]
        public void DebitarComSaldoZero()
        {
            conta.Debitar(50);
            Assert.AreEqual(0, conta.Saldo);
        }

        [Test]
        public void DebitarComSaldoMaior()
        {
            conta.Creditar(50);
            conta.Debitar(30);
            Assert.AreEqual(20, conta.Saldo);
        }

    }
}