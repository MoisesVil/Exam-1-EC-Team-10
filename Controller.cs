using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_EC
{
    internal class Controller
    {
        public LibraryModel m;

        public SyncLibrary sync;

        /// <summary>
        /// Constructor for the Controller Class
        /// </summary>
        /// <param name="model">Model to be used</param>
        public Controller(LibraryModel model)
        {
            this.m = model;
        }

        public void setSyncLib(SyncLibrary s)
        {
            this.sync = s;
        }

        /// <summary>
        /// Method to flip a page in a book
        /// </summary>
        /// <param name="isbn">Book being read</param>
        public void FlipPage(string isbn, bool flipRight)
        {
            Book b = m.GetBookData(isbn);

            if (flipRight && (b.CurrPage + 1 <= b.pages.Count))
            {
                m.GetBookData(isbn).CurrPage += 1;
            }
            else if (!flipRight && (b.CurrPage - 1 >= 0))
            {
                b.CurrPage -= 1;
            }
        }

        /// <summary>
        /// Set a bookmark in certain page in a book
        /// </summary>
        /// <param name="page">Page to set the bookmark on</param>
        /// <param name="isbn">Book to set the bookmark in</param>
        public void SetBookmark(int page, string isbn)
        {
            Book b = m.GetBookData(isbn);

            if (b.bookmarkAmount < 5)
            {
                //remove bookmark
                if (b.pages.ElementAt(b.CurrPage - 1).isBookmarked == true)
                {
                    b.pages.ElementAt(b.CurrPage - 1).isBookmarked = false;
                    b.bookmarkAmount -= 1;
                }
                //set bookmark
                if (b.pages.ElementAt(b.CurrPage - 1).isBookmarked == false) 
                { 
                    b.pages.ElementAt(b.CurrPage - 1).isBookmarked = true;
                    b.bookmarkAmount += 1;
                }
            }
        }

        /// <summary>
        /// Go to a certain page in a book
        /// </summary>
        /// <param name="page">Page to go to</param>
        /// <param name="isbn">Book being read</param>
        public void GoToPage(int page, string isbn)
        {
            m.GetBookData(isbn).CurrPage = page;
        }

        /// <summary>
        /// Adds a book to the library
        /// </summary>
        /// <param name="b">Book to be added</param>
        public void AddBook(Book b)
        {
            m.Update(b);
            sync();
        }
        public void ReturnBook(Book b)
        {
            m.DeleteFromLib(b);
            sync();
        }
    }
}
