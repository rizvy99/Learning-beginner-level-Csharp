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
            Console.Write("Enter customer name:");
            string name = Console.ReadLine();

            Console.Write("Enter customer address:");
            string address = Console.ReadLine();

            Console.Write("Enter customer phone number:");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter customer ID:");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Is the customer on mailing list? (true/false):");
            bool onMailingList = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter customer purchases amount:");
            double purchasesAmount = Convert.ToDouble(Console.ReadLine());

            PreferredCustomer preferredCustomer = new PreferredCustomer(name, address, phoneNumber, customerId, onMailingList, purchasesAmount);
            preferredCustomer.ShowInfo();

            Console.ReadLine();
        }
    }
}
