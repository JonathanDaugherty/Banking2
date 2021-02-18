using System;
using System.Collections.Generic;
using System.Text;

namespace Banking2 {
    class SavingsInheritance : Account {
        
        public decimal InterestRate { get; set; } = 0.12m;

        private decimal Interest(int months) {
            return Balance * (InterestRate / 12) * months;
        }

        public void PayInterest(int months) {
            var interest = Interest(months);
            Deposit(interest);
        }
       
        public SavingsInheritance() { }

    }
}
