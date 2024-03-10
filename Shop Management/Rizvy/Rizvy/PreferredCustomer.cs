using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizvy
{
    class PreferredCustomer : Customer
    {
        public double OverallPurchases { get; set; }
        public int DiscountLevel { get; set; }
        public PreferredCustomer(string name, string address, string phoneNumber, int customerNumber, bool isOnMailingList, double overallPurchases)
            : base(name, address, phoneNumber, customerNumber, isOnMailingList)
        {
            OverallPurchases = overallPurchases;
            SetDiscountLevel();
        }
        public void SetDiscountLevel()
        {
            if (OverallPurchases >= 2000)
            {
                DiscountLevel = 7;
            }
            else if (OverallPurchases >= 1500)
            {
                DiscountLevel = 5;
            }
            else if (OverallPurchases >= 1000)
            {
                DiscountLevel = 2;
            }
            else if (OverallPurchases >= 500)
            {
                DiscountLevel = 1;
            }
            else
            {
                DiscountLevel = 0;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("\n"); 
            Console.WriteLine("Customer's Name is                      : " + Name);
            Console.WriteLine("Customer's Address is                   : " + Address);
            Console.WriteLine("Customer's Phone Number is              : " + PhoneNumber);
            Console.WriteLine("Customer's Number is                    : " + CustomerNumber);
            Console.WriteLine("Customer wishes to be on a Mailing List : " + IsOnMailingList);
            Console.WriteLine("Customer's Overall Purchases            : " + OverallPurchases);
            Console.WriteLine("Customer's Discount Level               : " + DiscountLevel + "%");
        }
    }
}
