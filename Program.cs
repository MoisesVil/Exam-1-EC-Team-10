using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_1_EC
{
    public delegate void SyncLibrary();

    public delegate int FlipPage(string isbn, bool flipRight);

    public delegate void SetBookMark(int page, string isbn);

    public delegate int GoToPage(int page, string isbn);

    public delegate void AddBook(Book b);

    public delegate void ReturnBook(Book b);

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LibraryModel model = new LibraryModel();
            Controller cont = new Controller(model);
            LibraryView vM = new LibraryView(model,cont.AddBook, cont.FlipPage, cont.SetBookmark, cont.ReturnBook, cont.GoToPage);
            cont.setSyncLib(vM.SyncLibraryMethod);
            Application.Run(vM);
        }
    }
}
