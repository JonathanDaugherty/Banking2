using System;

namespace Banking2 {
    class Program {
        static void Main(string[] args) {
            
            var sav1 = new SavingsInheritance();
            var sav2 = new SavingsComposition();
            sav1.InterestRate = 0.13m;
            sav1.Deposit(50);
            sav1.withdraw(20);
            sav1.withdraw(50);
            sav1.Deposit(-20);
            sav1.Deposit(70);
            Console.WriteLine($"Balance is {sav1.Balance}");
            sav1.PayInterest(3);
            Console.WriteLine($"Balance after interest is {sav1.Balance}");


            //var Acct2 = new Account("Acct101, Jonathan's Account");
            //Acct2.Deposit(500);
            //Console.WriteLine($"Current Balance in {Acct2.Description} is {Acct2.Balance}" );
            //Acct2.withdraw(600);
            //Console.WriteLine($"Current Balance in {Acct2.Description} is {Acct2.Balance}");
            //Acct2.withdraw(330);
            //Console.WriteLine($"Current Balance in {Acct2.Description} is {Acct2.Balance}");




        }
    }
}
