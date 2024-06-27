namespace Account.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanlimit)
        : base(number, holder, balance)
        {
            this.LoanLimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
