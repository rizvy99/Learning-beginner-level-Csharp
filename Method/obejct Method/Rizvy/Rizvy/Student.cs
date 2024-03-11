using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizvy
{
    class Student
    {
        public string name;
        public string group;
        public double gpa;

        public Student(){}
        public Student(string nam,string grp , double g)
        {
            name = nam;
            group = grp;
            gpa = g;
        }
        public bool result()
        {
            if (gpa >= 3.50)
            {
                return true;
            }
            return false;
        }

    }
}
