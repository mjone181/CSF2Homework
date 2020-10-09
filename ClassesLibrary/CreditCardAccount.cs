using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //fields
        private int _accountNumber;
        private Customer _customer;
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualInterestRate;

        //properties
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }//end AccountNumber

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }//end Customer

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }//end Balance

        public bool IsPastDue
        {
            get { return _isPastDue; }
            set { _isPastDue = value; }
        }//end IsPastDue

        public decimal AnnualInterestRate
        {
            get { return _annualInterestRate; }
            set { _annualInterestRate = value; }
        }//end AnnualInterestRate

        //constructors
        public CreditCardAccount(int accountNumber, Customer customer, decimal balance, bool isPastDue, decimal annualInterestRate )
        {
            AccountNumber = accountNumber;
            Customer = customer;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }//end FQCTOR

        public CreditCardAccount() { }//end CreditCardAccount

        //methods
        public override string ToString()
        {
            return string.Format($"Account Number: {AccountNumber}\nCustomer:\n{Customer}Balance: {Balance:c}\nPast Due? {IsPastDue}\nAnnual Interest Rate: {AnnualInterestRate:n2}%\n");
        }//end ToString()

    }//end class
}//end namespace
