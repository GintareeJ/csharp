using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountsApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber{ get; set; }
        public decimal Balance { get; protected set; }
        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber= Guid.NewGuid();
            Balance = 0;
        }
        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0) return "You can not deposit "+amount;
            if (amount > 100000) return "Deposit limit reached";

            Balance += amount;
            return "Deposit completed successfully!";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0) return "You can not withdraw " + amount;
            if (amount > Balance) return "You do not have enough money";

            Balance -= amount;
            return "Withdraw completed successfully!";
        }
    }
}
