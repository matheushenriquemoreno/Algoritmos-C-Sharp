using System;


namespace heranca.Entities
{
   class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {


        }

        public SavingAccount(int number, string holder, double balance, double interestrate) : base(number, holder, balance)
        {
            InterestRate = interestrate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount); // utilizando a regra da super classe 
            Balance -= 2.0;
        }
    }
}
