using System.Globalization;

namespace Acc.Entities
{
    abstract internal class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
        }

        //virtual : o método pode ser sobrescrito/sobreposto nas subclasses
        public virtual void Withdraw(double amount)
        {
            this.Balance -= amount + 5.00;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount + 5.00;
        }

        public override string ToString()
        {
            return "Account: "
                + Number
                + ", Client: "
                + Holder
                + ", Balance: "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
