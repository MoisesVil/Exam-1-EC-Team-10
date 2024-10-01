using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_EC
{
    public class Book
    {
        public string name;
        public State state;
        public List<Page> pages;
        public int bookmarkAmount;
        public string isbn;

        public Book(string name, State s, List<Page> pages, string isbn) 
        {
            this.name = name;
            state = s;
            this.pages = pages;
            this.isbn = isbn;
        }
    }
}
