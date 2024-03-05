using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizvy
{
    class Book
    {
        public string title;
        public string author;
        public int page;
        public Book() { }
        public Book(string aTitle,string aAuthor,int tPage)
        {
            title = aTitle;
            author = aAuthor;
            page = tPage;
        }



    }
}
