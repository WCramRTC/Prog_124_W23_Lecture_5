using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_5
{
    // Polymorphism
    // What types are checking account - Account, CheckingAccount, object
    public class CheckingAccount : Account
    {

        decimal _overdraftFee = 20;
        public CheckingAccount()
        {

        }

        public CheckingAccount(string firstName, string lastName, decimal balance, AccountType typeOfAccount) : base(firstName, lastName, balance, typeOfAccount)
        {
        }
    }
}
