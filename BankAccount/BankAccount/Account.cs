using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Account
    {
        public int AccNumber { get; private set; }
        public string ClientName { get;  set; }
        public double Amount { get; private set; }

        public Account(int accNumber, string clientName)
        {
            AccNumber = accNumber;
            ClientName = clientName;
        }

        public Account(int accNumber, string clientName, double amount) : this(accNumber, clientName)
        {
            Amount = amount;
        }

        public void Withdraw(double withdrawAmount)
        {
            if (withdrawAmount <= Amount) {
                Amount -= withdrawAmount + 5.00;
            }
        } 

        public void Deposit(double depositAmount)
        {
            Amount += depositAmount;
        }

        public override string ToString()
        {
            return "Conta "
                + AccNumber
                + ", Titular: "
                + ClientName
                + ", Saldo: $"
                + Amount.ToString("F2", CultureInfo.InvariantCulture)
                + "\n";
        }

    }
}
