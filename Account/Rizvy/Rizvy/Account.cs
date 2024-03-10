using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizvy
{
    class Account
    {
        private String accname;
        private String accid;
        private int balance;
        public Account() { }
        public Account(String accname, String accid, int balance)
        {
            this.accname = accname;
            this.accid = accid;
            this.balance = balance;
        }
        public void setName(String accname) { this.accname = accname; }
        public String getName() { return accname; }
        public void setId(String accid) { this.accid = accid; }
        public String getId() { return accid; }
        public void setBalance(int balance) { this.balance = balance; }
        public int getBalance() { return balance; }

        public void ShowInfo()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name is        : " + accname);
            Console.WriteLine("Id is          : " + accid);
            Console.WriteLine("Old balance is : " + balance);
            Console.WriteLine("-----------------------------------");
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine(+amount + " has been deposited to " + accname + "'s account. New balance is : " + balance);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine(+amount + " has been withdrawn from " + accname + "'s account. New balance is : " + balance);
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }

        public void Transfer(int amount, Account receiver)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                receiver.Deposit(amount);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Transferred " + amount + " to " + receiver.accname + ". New balance of " + accname + " is : " + balance);
            }
            else
            {
                Console.WriteLine("Invalid transfer amount or insufficient balance.");
            }
        }

    }
}
 
