using Prog_124_W23_Lecture_5.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_5
{
    public class Account
    {
        // Enumeration
        public enum AccountType { Checking, Savings, Retirement }

        string _id;
        string _firstName;
        string _lastName;
        internal decimal _balance;
        AccountType _typeOfAccount;

        public Account()
        {

        }

        public Account(string firstName, string lastName, decimal balance, AccountType typeOfAccount)
        {
            Random rand = new Random();
            // 10000000 - 99999999
            int uniqueNumber = rand.Next(10000000, 100000000);

            _id = uniqueNumber.ToString();
            _firstName = firstName;
            _lastName = lastName;
            _balance = balance;
            _typeOfAccount = typeOfAccount;
        }

        public string Id { get => _id;}
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public decimal Balance { get => _balance; set => _balance = value; }
        public AccountType TypeOfAccount { get => _typeOfAccount; set => _typeOfAccount = value; }

        // Talk more about overriding methods next class
        public void Withdraw(decimal amount)
        {
 
        }



        // HOw to override a method
        public override string ToString()
        {
            //string accountInfomation = $"{account.FirstName} {account.LastName} - {account.Balance.ToString("c")} {account.TypeOfAccount}";

            return $"{_firstName} {_lastName} - {_balance.ToString("c")} {_typeOfAccount}";
        }


        // Checkings or Saving
        // Type of account - string
        // balance - decimal
        // identifying number - string
        // first name - string
        // last name - string
    }
}
