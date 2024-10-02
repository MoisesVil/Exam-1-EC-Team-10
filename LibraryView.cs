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
        public LibraryView(LibraryModel lM, AddBook ad)
        {
            InitializeComponent();
            libraryModel = lM;
            addBook = ad;
            fillCloudLibOnOpen();
            fillLibOnOpen();

            listBookLib.SelectedIndexChanged += ListBoxNewSelection;
            listCloudLib.SelectedIndexChanged += ListBoxNewSelection;
        }
        private AddBook addBook;
        private LibraryModel libraryModel;

        private void addToLibBtnClick(object sender, EventArgs e)
        {
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

            using (BookView bookView = new BookView(selectedBook)) 
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
    }
}
