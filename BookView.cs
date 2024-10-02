using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        /// <summary>
        /// Method to handle flipping a page to the right
        /// </summary>
        /// <param name="sender">the object signaling the event</param>
        /// <param name="e">information about the event</param>
        private void flipRight_Click(object sender, EventArgs e)
        {
            flipDel(selectedBook.isbn, true);
        }

        /// <summary>
        /// Method to handle flipping a page to the left
        /// </summary>
        /// <param name="sender">the object signaling the event</param>
        /// <param name="e">information about the event</param>
        private void flipLeft_Click(object sender, EventArgs e)
        {
            flipDel(selectedBook.isbn, false);
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
    }
}
