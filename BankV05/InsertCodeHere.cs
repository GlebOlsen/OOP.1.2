using System;

namespace BankV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount myAccount = new BankAccount("Gleb",20);
            BankAccount myAccount1 = new BankAccount("John",20);
            BankAccount myAccount2 = new BankAccount("Mikkel",25);
            BankAccount myAccount3 = new BankAccount("Simon",23);



            myAccount.Deposit(2000);
            myAccount.Withdraw(1500);
            myAccount.Deposit(9000);
            Console.WriteLine($"{myAccount.accountHoldName}'s aged {myAccount.ageofperson} account balance is over : {myAccount.Balance}");

            myAccount1.Deposit(3000);
            myAccount1.Withdraw(2500);
            myAccount1.Deposit(9000);
            Console.WriteLine($"{myAccount1.accountHoldName}'s aged {myAccount1.ageofperson} account balance is over : {myAccount1.Balance}");

            myAccount2.Deposit(4000);
            myAccount2.Withdraw(3500);
            myAccount2.Deposit(9000);
            Console.WriteLine($"{myAccount2.accountHoldName}'s aged {myAccount2.ageofperson} account balance is over : {myAccount2.Balance}");

            myAccount3.Deposit(5000);
            myAccount3.Withdraw(4500);
            myAccount3.Deposit(9000);
            Console.WriteLine($"{myAccount3.accountHoldName}'s aged {myAccount3.ageofperson} account balance is over : {myAccount3.Balance}");  


            // The LAST line of code should be ABOVE this line
        }
    }
}