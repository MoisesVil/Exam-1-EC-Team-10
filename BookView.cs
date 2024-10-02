using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_1_EC
{
    public partial class BookView : Form
    {
        private FlipPage flipDel;
        private LibraryModel model;
        private SetBookMark bookMark;
        private Book selectedBook;

        /// <summary>
        /// Constructor for bookview
        /// </summary>
        /// <param name="selectedBook">the selected book</param>
        public BookView(Book selectedBook, LibraryModel m, FlipPage f, SetBookMark b)
        {
            InitializeComponent();
            this.selectedBook = selectedBook;
            this.Text = selectedBook.name;
            flipDel = f;
            model = m;
            bookMark = b;
            pageText.Text = "Page: " + selectedBook.CurrPage.ToString();
            bookmarkButton_Click += CheckBookMark;
        }

        /// <summary>
        /// Method to handle flipping a page to the right
        /// </summary>
        /// <param name="sender">the object signaling the event</param>
        /// <param name="e">information about the event</param>
        private void flipRight_Click(object sender, EventArgs e)
        {
            selectedBook.CurrPage = flipDel(selectedBook.isbn, true);
            UpdateFlipPage(selectedBook.CurrPage);
        }

        /// <summary>
        /// Method to handle flipping a page to the left
        /// </summary>
        /// <param name="sender">the object signaling the event</param>
        /// <param name="e">information about the event</param>
        private void flipLeft_Click(object sender, EventArgs e)
        {
            selectedBook.CurrPage = flipDel(selectedBook.isbn, false);
            UpdateFlipPage(selectedBook.CurrPage);
        }

        /// <summary>
        /// Method to handle setting a bookmark
        /// </summary>
        /// <param name="sender">the object signaling the event</param>
        /// <param name="e">information about the event</param>
        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            bookMark(selectedBook.CurrPage, selectedBook.isbn);
        }

        /// <summary>
        /// Updates the page if flipped
        /// </summary>
        /// <param name="page">the page to flip to</param>
        private void UpdateFlipPage(int page) 
        {
            pageText.Text = "Page: " + page.ToString();
        }
        private void CheckBookMark()
        {
            foreach(Page p in selectedBook.pages)
            {
                if (p.pageNum == selectedBook.CurrPage)
                {
                    if (p.isBookmarked)
                    {
                        bookM.Text = "Bookmarked";
                    }
                    else
                    {
                        bookM.Text = "";
                    }
                }
            }
        }
    }
}
