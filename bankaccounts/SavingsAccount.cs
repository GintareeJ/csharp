using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountsApp
{
    internal class SavingsAccount : BankAccount 
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate):base(owner + " (" + interestRate + "%)")
        {
            InterestRate = interestRate;
        }
        public override string Deposit(decimal amount)
        {
            if (amount <= 0) return "You can not deposit " + amount;
            if (amount > 100000) return "Deposit limit reached";

            decimal interestAmount = (InterestRate/100)*amount;
            Balance += amount + interestAmount;
            return "Deposit completed successfully!";
        }
    }
}
