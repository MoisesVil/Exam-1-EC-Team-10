using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

        #region GetData
        /// <summary>
        /// Gets the data of a book
        /// </summary>
        /// <returns>the list of books</returns>
        public List<Book> GetCloudData()
        {
            return cloudBooks;
        }

        /// <summary>
        /// Gets the data of a book
        /// </summary>
        /// <returns>the list of books</returns>
        public List<Book> GetLibraryData()
        {
            return libraryBooks;
        }
        
        /// <summary>
        /// Gets a single book from an isbn number
        /// </summary>
        /// <param name="isbn">the isbn of the book</param>
        /// <returns>the book</returns>
        public Book GetBookData(string isbn)
        {
            foreach (Book b in libraryBooks)
            {
                if (b.isbn.Equals(isbn)) return b;
            }
            return null;
        }
        #endregion

        #region Updates
        /// <summary>
        /// Updates the model by adding the book
        /// </summary>
        /// <param name="book">the book to add</param>
        public void Update(Book book)
        {
            if (libraryBooks.Contains(book)) return;
            libraryBooks.Add(book);
            string file = "library.txt";
            StringBuilder str = new StringBuilder();
            str.Append($"{book.name}|{book.isbn}|{book.bookmarkAmount}|");
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                int i = 0;
                foreach (Page p in book.pages)
                {
                    i++;
                    str.Append($"{p.pageNum}%{p.isBookmarked}%{p.text}");
                    if (i != book.pages.Count) { str.Append("+"); }
                }
                sw.WriteLine(str);
            }
        }

        /// <summary>
        /// Method to remove books from the library
        /// </summary>
        /// <param name="book">Book to remove</param>
        public void DeleteFromLib(Book book)
        {
            libraryBooks.Remove(book);

            using (StreamReader sr = new StreamReader("library.txt"))
            {
                using (StreamWriter sw = new StreamWriter("temp.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.Contains(book.name))
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
            }

            File.Delete("library.txt");
            File.Move("temp.txt", "library.txt");
        }

        /// <summary>
        /// Method to set or remove a bookmark in a book
        /// </summary>
        /// <param name="book">Book to add/remove bookmark in</param>
        public void SetBookmark(Book book)
        {
            using (StreamReader sr = new StreamReader("library.txt"))
            {
                using (StreamWriter sw = new StreamWriter("temp.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        //If not current book, add back to file
                        if (!line.Contains(book.name))
                        {
                            sw.WriteLine(line);
                        }
                        //Current book to edit bookmark
                        else
                        {
                            StringBuilder str = new StringBuilder();
                            str.Append($"{book.name}|{book.isbn}|{book.bookmarkAmount}|");
                            string[] split = line.Split('|');
                            int i = 0;
                            foreach (string s in split[3].Split('+'))
                            {
                                string[] splitPages = s.Split('%');

                                //If this page needs to add/remove bookmark
                                if (book.CurrPage + 1 == int.Parse(splitPages[0]))
                                {
                                    //remove bookmark
                                    if (splitPages[1] == "True")
                                    {
                                        str.Append($"{book.pages[i].pageNum}%False%{book.pages[i].text}");
                                    }
                                    //set bookmark
                                    else
                                    {
                                        str.Append($"{book.pages[i].pageNum}%True%{book.pages[i].text}");
                                    }
                                }
                                //Add page and not change bookmark status
                                else
                                {
                                    str.Append($"{book.pages[i].pageNum}%{book.pages[i].isBookmarked}%{book.pages[i].text}");
                                }
                                if ((i + 1) != book.pages.Count) { str.Append("+"); }

                                i++;
                            }
                            sw.WriteLine(str);
                        }
                    }
                }
            }

            File.Delete("library.txt");
            File.Move("temp.txt", "library.txt");
            File.Delete("temp.txt");
        }
        #endregion

        /// <summary>
        /// Method to read in book data from text file 
        /// </summary>
        /// <param name="file">File to read from</param>
        private void LoadFile(string file)
        {
            bool check = false;
            if (file.Equals("bookLog.txt")) { check = true; }
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (!sr.EndOfStream)
                    {
                        List<Page> loadPages = new List<Page>();
                        string line = sr.ReadLine();
                        string[] split = line.Split('|');
                        foreach (string s in split[3].Split('+'))
                        {
                            string[] splitPages = s.Split('%');
                            Page p = new Page
                            {
                                pageNum = int.Parse(splitPages[0]),
                                isBookmarked = bool.Parse(splitPages[1]),
                                text = splitPages[2]
                            };
                            loadPages.Add(p);
                        }
                        Book loadBook = new Book
                        {
                            name = split[0],
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
