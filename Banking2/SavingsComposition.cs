using System;
using System.Collections.Generic;
using System.Text;

namespace Banking2 {
    class SavingsComposition {

        public decimal InterestRate { get; set; } = 0.12m;
            
        public Account Account { get; set; }

        private decimal Interest(int months) {
            return Account.Balance * (InterestRate / 12) * months;      
        }

        public void PayInterest(int months) {
            var interest = Interest(months);
            Deposit(interest);
        }

        public decimal Balance {
            get { return Account.Balance; }
        }
        
        public void Deposit(decimal amount) {
            Account.Deposit(amount);
        }

        public void Withdraw(decimal amount) {
            Account.withdraw(amount);
        }
        
        public SavingsComposition() {
            this.Account = new Account("4", "Savings Account");       
        }

         
    }
}
