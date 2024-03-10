using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizvy
{
    class Customer : Person
    {
        public int CustomerNumber { get; set; }
        public bool IsOnMailingList { get; set; }
        public Customer(string name, string address, string phoneNumber, int customerNumber, bool isOnMailingList)
            : base(name, address, phoneNumber)
        {
            CustomerNumber = customerNumber;
            IsOnMailingList = isOnMailingList;
        }
    }

}
