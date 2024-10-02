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
        public void fillCloudLibOnOpen()
        {
            foreach (Book b in libraryModel.GetCloudData())
            {
                listCloudLib.Items.Add(b);
            }
        }

        public void fillLibOnOpen()
        {
            foreach (Book b in libraryModel.GetLibraryData())
            {
                listBookLib.Items.Add(b);
            }
        }

        private void viewBookBtn(object sender, EventArgs e)
        {
            Book selectedBook = new Book();
            if(listBookLib.SelectedItem != null) selectedBook = listBookLib.SelectedItem as Book;
            if (listCloudLib.SelectedItem != null) selectedBook = listCloudLib.SelectedItem as Book;

            using (BookView bookView = new BookView(selectedBook, libraryModel, flipDel, bookMark )) 
            {
                if (bookView.ShowDialog() == DialogResult.OK) { }
            }
        }
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
            }
            else if (sender == listBookLib)
            {
                listCloudLib.ClearSelected();
                viewABookBtn.Enabled = true;
                addToLibBtn.Enabled = false;
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            retBook((Book)listBookLib.SelectedItem);
        }
    }
}
