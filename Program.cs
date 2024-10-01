using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_1_EC
{
    public delegate void SyncLibrary();

    public delegate void FlipPage(string isbn, bool flipRight);

    public delegate void SetBookMark(int page, string isbn);

    public delegate void GoToPage(int page, string isbn);

    public delegate void AddBook(Book b);

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
            LibraryView vM = new LibraryView(model);
            Application.Run(vM);
        }
    }
}
