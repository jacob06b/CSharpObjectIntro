using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpObjectIntro.Classes.Diary;
using CSharpObjectIntro.Classes.BankAccount;

namespace CSharpObjectIntro
{
    internal class OOPExercises
    {
        internal static void Run()
        {
            UseDiary();
            UseBankAccount();
        }

        internal static void UseDiary()
        {
            
            Diary book = new Diary("Bob Smith");
            Console.WriteLine(book.Name);
            DateOnly eventdate = new DateOnly(2022, 10, 15);
            // Add some events to your diary

            book.AddEvent(eventdate, 21, "football", "chiswick");
            book.AddEvent(eventdate, 15, "school", "barnes");
            // Now check how many events you have on a particular day
            int NumEvents = book.CheckDiary(eventdate);
            Console.WriteLine(NumEvents);
            // Implement a new method in the Diary class to return the number of morning events on a particular day
            // Call this method
            
        }

        internal static void UseBankAccount()
        {
            // Implement your bank account class following the instructions in the BankAccount class

            Console.WriteLine();
            BankAccount bankAccount = new BankAccount(120, DateTime.Today, 100);
            Console.WriteLine(bankAccount.Balance);
            bankAccount.deposit(29);
            bankAccount.withdraw(105);
            bankAccount.withdraw(67);
            bankAccount.MakeTransaction(DateTime.Now, 150, "grocery", "waitrose", "card");
            // Write calling code from here
        }
    }
}

