using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_EC
{
    /// <summary>
    /// Class for a book
    /// </summary>
    public class Book
    {
        public string name;
        public State state;
        public List<Page> pages;
        public int bookmarkAmount;
        public string isbn;
        public int CurrPage;

        /// <summary>
        /// overridden toString method 
        /// </summary>
        /// <returns>the name of the book</returns>
        public override string ToString()
        {
            return name;
        }

        public bool Equals(Book other)
        {
            return (this.name.Equals(other.name) && this.state == other.state &&
                this.bookmarkAmount == other.bookmarkAmount && this.isbn.Equals(other.isbn) && this.CurrPage == other.CurrPage);
        }
    }
}
