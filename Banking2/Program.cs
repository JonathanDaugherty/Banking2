using System;

namespace Banking2 {
    class Program {
        static void Main(string[] args) {
            var Acct2 = new Account("Acct101, Jonathan's Account");
            Acct2.Deposit(500);
            Console.WriteLine($"Current Balance in {Acct2.Description} is {Acct2.Balance}" );
            Acct2.withdrawal(600);
            Console.WriteLine($"Current Balance in {Acct2.Description} is {Acct2.Balance}");
            Acct2.withdrawal(330);
            Console.WriteLine($"Current Balance in {Acct2.Description} is {Acct2.Balance}");




        }
    }
}
