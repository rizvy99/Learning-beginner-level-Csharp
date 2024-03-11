using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizvy
{
    class Program
    {
    class NamedParameterExample
        {
            static string GetFullName(string firstName, string lastName)
            {
                return firstName + " " + lastName;
            }

            static void Main(string[] args)
            {
                string fullName1 = GetFullName("Lionel", "Messi"); // Without named arguments  
                string fullName2 = GetFullName(firstName: "Lionel", lastName: "Messi"); // Named arguments  
                string fullName3 = GetFullName(lastName: "Messi", firstName: "Lionel"); // Changing order of the string value but still prints the same name in same order  
                Console.WriteLine(fullName1);
                Console.WriteLine(fullName2);
                Console.WriteLine(fullName3);

                Console.ReadKey();
            }
        }
    }

}