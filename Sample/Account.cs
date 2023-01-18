using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_5.Sample
{
    public class Account
    {
        protected string _id;
        protected double _balance;
        static int _numberOfAccounts = 0;

        public Account(string id, double balance)
        {
            _id = id;
            _balance = balance;
            _numberOfAccounts++;
        } // Account

        public string ID
        {
            get => _id;
            set => _id = value;
        }

        public static int NumberOfAccounts
        {
            get => _numberOfAccounts;
        }
        
    }
}
