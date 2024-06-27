namespace Acc.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            this.InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            this.Balance += Balance * InterestRate;
        }

        public override string ToString()
        {
            return "Account: "
                + Number
                + ", Client: "
                + Holder
                + ", Balance: "
                + Balance;
        }
    }
}
