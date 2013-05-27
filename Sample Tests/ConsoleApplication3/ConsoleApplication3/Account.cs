using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace Bank
{
    public class Account
    {
        private decimal balance;
        private int mul;

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine(balance);
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
            Console.WriteLine("With Draw:" +balance);
        }

        public void TransferFunds(Account destination, decimal amount)
        {

            Console.WriteLine("Transfer Fund:" + amount);
            destination.Deposit(amount);
            if (balance - amount < minimumBalance)
                throw new InsufficientFundsException();
            Withdraw(amount);
        }

        public decimal Balance
        {
            get { return balance; }

        }

        public void MultiplyOnetoTwen(int input)
        {
            for (int i = 1; i <= 10; i++)
            {
              
                Console.WriteLine(Convert.ToString(input) + "*" + Convert.ToString(i)+"=" + input * i);
            }

        }

        private decimal minimumBalance = 10m;

        public decimal MinimumBalance
        {
            get { return minimumBalance; }
        }
    }

    public class InsufficientFundsException : ApplicationException
    {
    }

  
 
  [TestFixture]
  public class AccountTest
  {
    Account source;
    Account destination;

    [SetUp]
    public void Init()
    {
      source = new Account();
      source.Deposit(200m);
	  
      destination = new Account();
      destination.Deposit(150m);
    }

    [Test]
    public void TransferFunds()
    {
      source.TransferFunds(destination, 100m);
	  
      Assert.AreEqual(250m, destination.Balance);
      Assert.AreEqual(100m, source.Balance);
    }

    [Test]
    [ExpectedException(typeof(InsufficientFundsException))]
    public void TransferWithInsufficientFunds()
    {
      source.TransferFunds(destination, 300m);
    }

    [Test]
    [Ignore("Decide how to implement transaction management")]
    public void TransferWithInsufficientFundsAtomicity()
    {
      try
      {
        source.TransferFunds(destination, 300m);
      }
      catch(InsufficientFundsException)
      {
      }

      Assert.AreEqual(200m, source.Balance);
      Assert.AreEqual(150m, destination.Balance);
    
  }
}
  }


