using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizvy
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Alrazi Hosen", "121314", 50000);
            a1.ShowInfo();
            a1.Deposit(500);

            Account a2 = new Account("Samiha Tabassum", "212324", 45000);
            a2.ShowInfo();
            a2.Withdraw(800);

            a1.Transfer(200, a2);

            Console.WriteLine("\n-----------------------------------\n");
            Console.WriteLine("New Account Balance of " + a1.getName() + " is : " + a1.getBalance());
            Console.WriteLine("New Account Balance of " + a2.getName() + " is : " + a2.getBalance());
            Console.ReadLine();
        }
    }
}
 
