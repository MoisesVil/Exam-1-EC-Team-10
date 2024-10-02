using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_EC
{
    /// <summary>
    /// The model class
    /// </summary>
    public class LibraryModel
    {
        private List<Book> cloudBooks = new List<Book>();
        private List<Book> libraryBooks = new List<Book>();

        /// <summary>
        /// Constructor
        /// </summary>
        public LibraryModel()
        {
            LoadFile("bookLog.txt");
            LoadFile("library.txt");
        }
        /// <summary>
        /// Gets the data of a book
        /// </summary>
        /// <returns>the list of books</returns>
        public List<Book> GetData()
        {
            return cloudBooks;
        }
        /// <summary>
        /// Gets the data of a book
        /// </summary>
        /// <returns>the list of books</returns>
        public List<Book> GetDataLibrary()
        {
            return libraryBooks;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>A singular book</returns>
        public Book GetBookData(string isbn)
        {
            return null;
        }

        /// <summary>
        /// Updates the model
        /// </summary>
        public void Update(Book book)
        {
            libraryBooks.Add(book);
            string file = "library.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.Write($"{book.name}|{book.isbn}|{book.bookmarkAmount}|");
                int i = 0;
                foreach (Page p in book.pages)
                {
                    i++;
                    sw.Write($"{p.pageNum}%{p.isBookmarked}");
                    if (i != book.pages.Count) { sw.Write("+"); }
                }
                sw.WriteLine();
            }
        }

        public void Delete(Book book)
        {
            cloudBooks.Remove(book);
        }
        private void LoadFile(string file)
        {
            List<Page> loadPages = new List<Page>();
            bool check = false;
            if (file.Equals("bookLog.txt")) { check = true; }
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] split = line.Split('|');
                        foreach (string s in split[3].Split('+'))
                        {
                            string[] splitPages = s.Split('%');
                            Page p = new Page
                            {
                                pageNum = int.Parse(splitPages[0]),
                                isBookmarked = bool.Parse(splitPages[1])
                            };
                            loadPages.Add(p);
                        }
                        Book loadBook = new Book
                        {
                            name = split[0],
                            state = State.Closed,
                            isbn = split[1],
                            bookmarkAmount = int.Parse(split[2]),
                            pages = loadPages
                        };
                        if (check) { cloudBooks.Add(loadBook); }
                        else { libraryBooks.Add(loadBook); }
                    }
                }
            }
        }
    }
}
