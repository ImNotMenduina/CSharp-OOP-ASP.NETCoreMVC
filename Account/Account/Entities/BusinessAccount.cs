namespace Acc.Entities
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

        //base : reaproveita operação da super classe
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); // taxa normal de saque (5.00 reais)
            this.Balance -= 5.00;
        }
    }
}
