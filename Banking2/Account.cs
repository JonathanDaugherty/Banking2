using System;
using System.Collections.Generic;
using System.Text;

namespace Banking2 {
    class Account {
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Description { get; set; }
        public string Accounttype { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount) {
            if (amount > 0) 
                { Balance += amount; }
        }

        public void withdrawal(decimal amount) {
            if(amount < 0) {
                return;
            }
            if(Balance >= amount) {
                Balance -= amount;
            } else {
                Console.WriteLine("Insufficient Funds");
            }
        }
            

            
        
    }
    
}