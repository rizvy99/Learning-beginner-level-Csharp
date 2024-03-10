using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizvy
{
    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;
        public Course() { }
        public Course(String courseName, String courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }
        public void setName(String courseName) { this.courseName = courseName; }
        public String getName() { return courseName; }
        public void setCode(String courseCode) { this.courseCode = courseCode; }
        public String getCode() { return courseCode; }
        public void setCredit(int courseCredit) { this.courseCredit = courseCredit; }
        public int getCredit() { return courseCredit; }

        public void ShowInfo()
        {
            Console.WriteLine("Course Name is   : " + courseName);
            Console.WriteLine("Course Code is   : " + courseCode);
            Console.WriteLine("Course Credit is : " + courseCredit);
            Console.WriteLine("\n**********************************************\n");
        }

    }
}
    