using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_5
{
    // Inheritance
    // Polymorphism - Many Types

    // Account is the parent class
    // Savings is the CHILD of Account ( Derived )
    // Savings Account ( is a ) Savings Account, Account, Object 
    internal class SavingsAccount : Account
    {

        // Fields
        double _interestAmount;

        // Add another paremeter to our constructor

        public SavingsAccount()
        {

        }


        public SavingsAccount(string firstName, string lastName, decimal balance, AccountType typeOfAccount, double interest) : base(firstName, lastName, balance, typeOfAccount)
        {
            _interestAmount = interest;
        }

        public double InterestAmount { get => _interestAmount; set => _interestAmount = value; }

        public void AddInterest()
        {
            Balance *= 1 + (decimal)_interestAmount;
        }
    }
}
