﻿using System;
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
            foreach (Book b in cloudBooks) 
            {
                if (b.isbn.Equals(isbn)) return b;
            }
            foreach (Book b in libraryBooks)
            {
                if (b.isbn.Equals(isbn)) return b;
            }
            return null;
        }

        /// <summary>
        /// Updates the model by adding the book
        /// </summary>
        /// <param name="book">the book to add</param>
        public void Update(Book book)
        {
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
                    str.Append($"{p.pageNum}%{p.isBookmarked}");
                    if (i != book.pages.Count) { str.Append("+"); }
                }
                sw.WriteLine(str);
            }
        }

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
