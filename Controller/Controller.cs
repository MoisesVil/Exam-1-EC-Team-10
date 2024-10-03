using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exam_1_EC
{
    internal class Controller
    {
        private LibraryModel m;

        private SyncLibrary sync;

        /// <summary>
        /// Constructor for the Controller Class
        /// </summary>
        /// <param name="model">Model to be used</param>
        public Controller(LibraryModel model)
        {
            this.m = model;
        }

        /// <summary>
        /// Sets the sync library delegate
        /// </summary>
        /// <param name="s">the delegate to set</param>
        public void setSyncLib(SyncLibrary s)
        {
            this.sync = s;
        }

        #region PageMethods
        /// <summary>
        /// Method to flip a page in a book
        /// </summary>
        /// <param name="isbn">Book being read</param>
        public int FlipPage(string isbn, bool flipRight)
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
            return b.CurrPage;
        }

        /// <summary>
        /// Method to handle going to a specific page
        /// </summary>
        /// <param name="pageNum">The page number to flip to</param>
        /// <param name="isbn">the isbn of the book</param>
        /// <returns>the page you flipped to</returns>
        public int GoToPage(int pageNum, string isbn)
        {
            Book book = m.GetBookData(isbn);
            if (pageNum >= 0 && pageNum <= book.pages.Count) book.CurrPage = pageNum;

            return book.CurrPage;
        }

        /// <summary>
        /// Set a bookmark in certain page in a book
        /// </summary>
        /// <param name="page">Page to set the bookmark on</param>
        /// <param name="isbn">Book to set the bookmark in</param>
        public void SetBookmark(int page, string isbn)
        {
            Book b = m.GetBookData(isbn);
            bool check = false;
                //remove bookmark
                if (b.pages[(b.CurrPage)].isBookmarked == true)
                {
                    m.GetBookData(isbn).pages.ElementAt(b.CurrPage).isBookmarked = false;
                    m.GetBookData(isbn).bookmarkAmount -= 1;
                    m.SetBookmark(b);
                    check = true;
                }
            if (b.bookmarkAmount < 5)
            {
                if (!check)
                {
                    //set bookmark
                    if (b.pages[(b.CurrPage)].isBookmarked == false)
                    {
                        m.GetBookData(isbn).pages.ElementAt(b.CurrPage).isBookmarked = true;
                        m.GetBookData(isbn).bookmarkAmount += 1;
                        m.SetBookmark(b);
                    }
                }
            }
            else
            {
                MessageBox.Show("Exceeded bookmark amount -- Can only bookmark 5 pages!");
            }
		}
        #endregion

        #region BookMethods
        /// <summary>
        /// Adds a book to the library
        /// </summary>
        /// <param name="b">Book to be added</param>
        public void AddBook(Book b)
        {
            m.Update(b);
            sync();
        }

        /// <summary>
        /// Returns a book to the cloud
        /// </summary>
        /// <param name="b">the book to return</param>
        public void ReturnBook(Book b)
        {
            m.DeleteFromLib(b);
            sync();
        }
        #endregion
    }
}
