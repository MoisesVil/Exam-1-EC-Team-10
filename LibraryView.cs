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
            SyncLibraryMethod();
        }
        private AddBook addBook;
        private LibraryModel libraryModel;

        private void addToLibBtnClick(object sender, EventArgs e)
        {
            addBook((Book)listCloudLib.SelectedItem);
        }
        public void fillCloudLibOnOpen()
        {
            foreach(Book b in libraryModel.GetData())
            {
                listCloudLib.Items.Add(b);
            }
        }

        private void viewBookBtn(object sender, EventArgs e)
        {
            BookView bV = new BookView();
            bV.Show();
        }
        public void SyncLibraryMethod()
        {
            foreach (Book b in libraryModel.GetDataLibrary())
            {
                listBookLib.Items.Add(b);
            }
        }
    }
}
