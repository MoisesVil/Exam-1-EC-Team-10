using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_EC
{
    /// <summary>
    /// The model class
    /// </summary>
    public class LibraryModel
    {
        private List<Book> books;

        /// <summary>
        /// Constructor
        /// </summary>
        public LibraryModel() 
        {
            if (File.Exists("bookLog.txt")) 
            {
                using (StreamReader sr = new StreamReader("bookLog.txt"))
                {
                    while (!sr.EndOfStream) 
                    {
                        string line = sr.ReadLine();
                        string[] split = line.Split('|');
                        Book loadBook = new Book
                        {
                            name = split[0],
                            state = State.Closed,
                            bookmarkAmount = int.Parse(split[1]),

                        };
                    }
                }
            }
        }
        /// <summary>
        /// Gets the data of a book
        /// </summary>
        /// <returns>the list of books</returns>
        public List<Book> GetData() 
        {
            return books;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>A singular book</returns>
        public Book GetBookData(string isbn) 
        {

        }

        /// <summary>
        /// Updates the model
        /// </summary>
        public void Update(Book book) 
        {
            books.Add(book);
            using (StreamWriter sw = new StreamWriter("bookLog.txt", true)) 
            {
                sw.WriteLine($"{book.name}|{book.isbn}|{book.bookmarkAmount}");
                foreach (Page p in book.pages) 
                {
                    sw.Write($"{p.pageNum}|{p.isBookmarked}");
                }
            }
        }

        public void Delete(Book book) 
        {
            books.Remove(book);
        }
    }
}
