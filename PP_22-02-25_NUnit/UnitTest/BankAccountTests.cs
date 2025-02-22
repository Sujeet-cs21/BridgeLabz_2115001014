using NUnit.Framework;
using PP_22_02_25_NUnit;
using System;

namespace UnitTest
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;

        [SetUp]
        public void Setup()
        {
            _account = new BankAccount(1000);  // Initial balance set to 1000
        }

        [Test]
        public void Deposit_ValidAmount_UpdatesBalance()
        {
            _account.Deposit(500);

            // Assert that the balance is correctly updated
            Assert.That(_account.GetBalance(), Is.EqualTo(1500));
        }

        [Test]
        public void Withdraw_ValidAmount_UpdatesBalance()
        {
            _account.Withdraw(300);

            // Assert that the balance is correctly updated
            Assert.That(_account.GetBalance(), Is.EqualTo(700));
        }

        [Test]
        public void Withdraw_AmountGreaterThanBalance_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _account.Withdraw(2000));
        }

        [Test]
        public void Deposit_NegativeAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _account.Deposit(-100));
        }

        [Test]
        public void Withdraw_NegativeAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _account.Withdraw(-50));
        }
    }
}
