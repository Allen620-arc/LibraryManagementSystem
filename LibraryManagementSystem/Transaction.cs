using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Transaction
    {
        public int BookId { get; set; }        // The ID of the borrowed or returned book
        public int MemberId { get; set; }      // The ID of the member who borrowed or returned the book
        public DateTime BorrowDate { get; set; } // The date and time when the book was borrowed
        public DateTime? ReturnDate { get; set; } // The date and time when the book was returned (nullable)

        public Transaction(int bookId, int memberId, DateTime borrowDate)
        {
            BookId = bookId;
            MemberId = memberId;
            BorrowDate = borrowDate;
            ReturnDate = null; // Initially, the book has not been returned
        }

    }
}
