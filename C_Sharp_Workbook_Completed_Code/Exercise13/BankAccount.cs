using System;

namespace Exercise13
{
    class BankAccount
    {
        double overdraftLimit;
        double interestRate;
        double currentBalance;

        public BankAccount(double initialFunds, double overdraftLimit, double interestRate)
        {
            this.overdraftLimit = overdraftLimit;
            this.interestRate = interestRate;
            currentBalance = initialFunds;

            Console.WriteLine("Account created with balance of £" + initialFunds + ", overdraft limit of £" + overdraftLimit + " and an interest rate of " + interestRate + "%");
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Account balance is: £" + currentBalance);
        }

        public void Deposit(double amount)
        {
            currentBalance += amount;
            Console.WriteLine("Deposit successful.");
        }

        public void Withdraw(double amount)
        {
            if(currentBalance - amount > overdraftLimit*-1)
            {
                currentBalance -= amount;
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("This will exceed your overdraft limit. Withdrawal rejected.");
            }
        }

        public void ApplyInterest()
        {
            currentBalance = currentBalance *= (1 + interestRate);
            Console.WriteLine("Interest has been applied.");
        }

    }
}
