using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Craft.Tests
{
    [TestClass]
    public class AccountBuilderTests
    {

        #region MyRegion
        [TestMethod]
        public void DemonstrationOfCreatingAccount()
        {
            var account = new Account();
            account.Balance = 9000;
            account.Customer = new Customer();
            account.Customer.Address = new Address();
            account.Customer.Address.City = "London";
            account.Customer.Address.Country = "UK";
            account.Customer.IsVip = true;
            account.DueDate = DateTime.Now.AddDays(-1);
            account.Customer.Name = "Penelope";
        }   
        #endregion        


        [TestMethod]
        public void CanCreateAccount()
        {
            var account = AccountBuilder.DefaultAccount().Build();

            Assert.IsNotNull(account);
        }

        [TestMethod]
        public void AssignsDefaultValues()
        {
            var account = AccountBuilder.DefaultAccount().Build();

            Assert.IsTrue(account.Balance > 0);
            Assert.IsTrue(account.DueDate > DateTime.Now);
            Assert.IsNotNull(account.Customer.Address.City);
            Assert.IsNotNull(account.Customer.Address.Country);
            Assert.IsFalse(account.Customer.IsVip);
            Assert.IsNotNull(account.Customer.Name);
        }

        [TestMethod]
        public void CanCreateLateAccount()
        {
            var account = AccountBuilder.DefaultAccount()
                                        .WithLatePaymentStatus()
                                        .Build();

            Assert.IsTrue(account.DueDate < DateTime.Now);
        }

        [TestMethod]
        public void CanCreateLateAccountWithVipCustomer()
        {
            var account = AccountBuilder.DefaultAccount()
                                            .WithLatePaymentStatus()
                                            .WithVipCustomer()
                                        .Build();

            Assert.IsTrue(account.Customer.IsVip);
        }


    }

    public class AccountBuilder
    {
        public static AccountBuilder DefaultAccount()
        {
            return new AccountBuilder();
        }

        public AccountBuilder()
        {
            _account = new Account();
            _account.Balance = 10000;
            _account.DueDate = DateTime.Now.AddDays(1);
            _account.Customer = new Customer();
            _account.Customer.Name = "Michelle";
            _account.Customer.IsVip = false;
            _account.Customer.Address = new Address();
            _account.Customer.Address.City = "D.C.";
            _account.Customer.Address.Country = "USA";
        }

        public Account Build()
        {
            return _account;
        }

        public AccountBuilder WithLatePaymentStatus()
        {
            _account.DueDate = DateTime.Now.AddDays(-1);
            return this;
        }

        public AccountBuilder WithVipCustomer()
        {
            _account.Customer.IsVip = true;
            return this;
        }

        private Account _account;
    }
}
