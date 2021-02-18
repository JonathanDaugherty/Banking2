using System;
using System.Collections.Generic;
using System.Text;

namespace Banking2.Exceptions {
    class InsufficientFundsException : Exception {

        public decimal AccountBalance { get; set; }

        public decimal AmountTowithdraw { get; set; }

        public InsufficientFundsException(decimal balance, decimal amount) : base($"current balance is {balance}, withdraw amount is {amount}") {
            AccountBalance = balance;
            AmountTowithdraw = amount;
        }


        public InsufficientFundsException()
            : base() { }

        public InsufficientFundsException(string Message)
            : base() { }

        public InsufficientFundsException(string Message, Exception InnerException)
            : base(Message, InnerException) { }


    }
}
