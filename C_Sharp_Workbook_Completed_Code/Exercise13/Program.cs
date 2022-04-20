using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(14000, 2000, 0.05);

            // This should be successful
            account1.Withdraw(4000);
            account1.DisplayBalance();

            // This should be successful
            account1.Withdraw(8000);
            account1.DisplayBalance();

            // This should be not be successful
            account1.Withdraw(8000);
            account1.DisplayBalance();

            account1.Deposit(350);
            account1.DisplayBalance();

            account1.ApplyInterest();
            account1.DisplayBalance();

        }
    }
}
