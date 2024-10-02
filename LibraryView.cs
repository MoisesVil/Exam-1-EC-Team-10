using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_1_EC
{
    public partial class LibraryView : Form
    {
        /// <summary>
        /// constructor for the library view
        /// </summary>
        /// <param name="lM">the library model</param>
        /// <param name="ad">the addbook delegate</param>
        /// <param name="f">the flip page delegate</param>
        /// <param name="b">the set bookmark delegate</param>
        /// <param name="retBook">the returnbook delegate</param>
        public LibraryView(LibraryModel lM, AddBook ad, FlipPage f, SetBookMark b , ReturnBook retBook)
        {
            InitializeComponent();
            libraryModel = lM;
            addBook = ad;
            fillCloudLibOnOpen();
            fillLibOnOpen();
            this.retBook = retBook; 
            flipDel = f;
            bookMark = b;
            listBookLib.SelectedIndexChanged += ListBoxNewSelection;
            listCloudLib.SelectedIndexChanged += ListBoxNewSelection;
            this.retBook = retBook;
        }
        private AddBook addBook;
        private LibraryModel libraryModel;
        private FlipPage flipDel;
        private SetBookMark bookMark;
        private ReturnBook retBook;

        /// <summary>
        /// Handles the code to add a book to your library
        /// </summary>
        /// <param name="sender">object signaling the event</param>
        /// <param name="e">information about the event</param>
        private void addToLibBtnClick(object sender, EventArgs e)
        {
            foreach (Book b in libraryModel.GetLibraryData()) 
            {
                if (b.Equals((Book)listCloudLib.SelectedItem)) 
                {
                    MessageBox.Show("Book already added to library");
                    return;
                }
            }

            addBook((Book)listCloudLib.SelectedItem);
        }

        /// <summary>
        /// fills the cloud with books in model
        /// </summary>
        public void fillCloudLibOnOpen()
        {
            foreach (Book b in libraryModel.GetCloudData())
            {
                listCloudLib.Items.Add(b);
            }
        }

        /// <summary>
        /// fills the library with books in model
        /// </summary>
        public void fillLibOnOpen()
        {
            foreach (Book b in libraryModel.GetLibraryData())
            {
                listBookLib.Items.Add(b);
            }
        }

        /// <summary>
        /// Handles the code to view a book
        /// </summary>
        /// <param name="sender">object signaling the event</param>
        /// <param name="e">information about the event</param>
        private void viewBookBtn(object sender, EventArgs e)
        {
            Book selectedBook = new Book();
            if(listBookLib.SelectedItem != null) selectedBook = listBookLib.SelectedItem as Book;
            if (listCloudLib.SelectedItem != null) selectedBook = listCloudLib.SelectedItem as Book;

            using (BookView bookView = new BookView(selectedBook, libraryModel, flipDel, bookMark)) 
            {
                if (bookView.ShowDialog() == DialogResult.OK) { }
            }
        }

        /// <summary>
        /// syncs the library to the model
        /// </summary>
        public void SyncLibraryMethod()
        {
            listBookLib.Items.Clear();
            foreach (Book b in libraryModel.GetLibraryData())
            {
                listBookLib.Items.Add(b);
            }
        }

        /// <summary>
        /// Handles the selection change in any ListBox to enable/disable the Edit and Delete buttons
        /// </summary>
        /// <param name="sender">object signaling the event</param>
        /// <param name="e">information about the event</param>
        private void ListBoxNewSelection(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex == -1) return;
            else if (sender == listCloudLib)
            {
                listBookLib.ClearSelected();
                viewABookBtn.Enabled = false;
                addToLibBtn.Enabled = true;
                returnBtn.Enabled = false;
            }
            else if (sender == listBookLib)
            {
                listCloudLib.ClearSelected();
                viewABookBtn.Enabled = true;
                addToLibBtn.Enabled = false;
                returnBtn.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the code to return a book
        /// </summary>
        /// <param name="sender">object signaling the event</param>
        /// <param name="e">information about the event</param>
        private void returnBtn_Click(object sender, EventArgs e)
        {
            retBook((Book)listBookLib.SelectedItem);
        }
    }
}
