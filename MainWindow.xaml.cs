using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_124_W23_Lecture_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Design Patterns
        // Oberserver pattern

        // ObservableCollection
        ObservableCollection<Account> accounts = new ObservableCollection<Account>();

        //List<Account> accounts = new List<Account>();

        public MainWindow()
        {
            InitializeComponent();
            ExampleCode();
            
        }

        public void ExampleCode()
        {
            accounts.Add(new SavingsAccount("Will", "Cram", 123.56m, Account.AccountType.Retirement, .05));
            accounts.Add(new Account("Hannah", "Angel", 123333.56m, Account.AccountType.Savings));
            accounts.Add(new Account("Dylan", "Register", 1233333.56m, Account.AccountType.Checking));

            lbAccounts.ItemsSource = accounts;

            SavingsAccount sa = new SavingsAccount("Will", "Cram", 123.56m, Account.AccountType.Retirement, .05);

            List<SavingsAccount> savingsAccounts = new List<SavingsAccount>();

            savingsAccounts.Add(new SavingsAccount("Zach", "Z", 123.56m, Account.AccountType.Retirement, .05));


            Account a = new SavingsAccount();
            Account a2 = new Account();

            SavingsAccount s = new SavingsAccount(); // A child is the same as a parent
            /*SavingsAccount s2 = new Account();*/ // A Parent is not the same as a child


            Account checking = new CheckingAccount();
            Account savings = new SavingsAccount();
            Account account = new Account();

            //SavingsAccount sa3 = new SavingsAccount();
            //SavingsAccount sa4 = new CheckingAccount();
            //SavingsAccount sa5 = new Account();

            // I & P - Everything is an object

        }

        private void btnAddAccount_Click(object sender, RoutedEventArgs e)
        {
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            decimal balance = decimal.Parse(txtBalance.Text);

            // Hold chosen enmerator
            Account.AccountType typeOfAccount;

            // Getting the radio button value for our enumerator
            // Nullable primitive

            if(rbSavings.IsChecked.Value)
            {
                typeOfAccount = Account.AccountType.Savings;
            }
            else if(rbChecking.IsChecked.Value) {
                typeOfAccount = Account.AccountType.Checking;
            }
            else
            {
                typeOfAccount = Account.AccountType.Retirement;
            }

            Account account = new Account(fName, lName, balance, typeOfAccount);

            accounts.Add(account);

            // Override
        }
    }
}
