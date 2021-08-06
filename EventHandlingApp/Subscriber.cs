using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventHandlingApp.Model;

namespace EventHandlingApp
{
    class Subscriber
    {
        static void Main(string[] args)
        {
            Account acc = new Account("Sid", 102, 5000);
            acc.BalanceChanged += SendSMS;
            acc.BalanceChanged += RefreshBalance;
            acc.BalanceChanged += PrintReciept;
            acc.deposit(2000);
            Console.ReadLine();
        }

        static void RefreshBalance(Account obj)
        {
            Console.WriteLine("\nRefreshing Account Balance Of "+obj.Name+": ");
            Console.WriteLine("Current Balance: " + obj.Balance);
        }

        static void PrintReciept(Account obj)
        {
            Console.WriteLine("\nGenerating Reciept of Account Holder: ");
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Acc No: " + obj.AccNo);
            Console.WriteLine("Balance: " + obj.Balance);
        }

        static void SendSMS(Account obj)
        {
            Console.WriteLine("\nSending SMS to " + obj.Name);
            Console.WriteLine("Your Current Balance is: " + obj.Balance);
        }
    }
}
