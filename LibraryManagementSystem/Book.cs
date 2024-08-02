using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int Id { get; set; }             // Unique identifier for the book
        public string Title { get; set; }       // Title of the book
        public string Author { get; set; }      // Author of the book
        public string ISBN { get; set; }        // ISBN number of the book
        public bool IsBorrowed { get; set; }    // Indicates whether the book is currently borrowed

        public Book(int id, string title, string author, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false; // When a book is created, it's not borrowed
        }
    }
}
