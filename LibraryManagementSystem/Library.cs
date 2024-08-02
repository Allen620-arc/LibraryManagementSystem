using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> books;
        private List<Member> members;
        private List<Transaction> transactions;

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
            transactions = new List<Transaction>();
        }

        #region Book Management

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(int bookId)
        {
            var book = books.FirstOrDefault(b => b.Id == bookId);
            if (book != null)
            {
                books.Remove(book);
            }
        }

        public void UpdateBook(Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (book != null)
            {
                book.Title = updatedBook.Title;
                book.Author = updatedBook.Author;
                book.ISBN = updatedBook.ISBN;
            }
        }

        public Book GetBook(int bookId)
        {
            return books.FirstOrDefault(b => b.Id == bookId);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public List<Book> SearchBooks(string searchTerm)
        {
            return books.Where(b => b.Title.Contains(searchTerm) || b.Author.Contains(searchTerm) || b.ISBN.Contains(searchTerm)).ToList();
        }

        #endregion

        #region Member Management
        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public void RemoveMember(int memberId)
        {
            var member = members.FirstOrDefault(m => m.Id == memberId);
            if (member != null)
            {
                members.Remove(member);
            }
        }

        public void UpdateMember(Member updatedMember)
        {
            var member = members.FirstOrDefault(m => m.Id == updatedMember.Id);
            if (member != null)
            {
                member.Name = updatedMember.Name;
                member.Email = updatedMember.Email;
            }
        }

        public Member GetMember(int memberId)
        {
            return members.FirstOrDefault(m => m.Id == memberId);
        }

        public List<Member> GetAllMembers()
        {
            return members;
        }

        public List<Member> SearchMembers(string searchTerm)
        {
            return members.Where(m => m.Name.Contains(searchTerm) ||
                                      m.Email.Contains(searchTerm)).ToList();
        }

        #endregion

        #region Transaction Management

        public void BorrowBook(int bookId, int memberId)
        {
            var book = books.FirstOrDefault(b => b.Id == bookId);
            var member = members.FirstOrDefault(m => m.Id == memberId);

            if (book != null && member != null && !book.IsBorrowed)
            {
                book.IsBorrowed = true;
                member.BorrowedBookIds.Add(bookId);
                transactions.Add(new Transaction(bookId, memberId, DateTime.Now));
            }
        }

        public void ReturnBook(int bookId, int memberId)
        {
            var book = books.FirstOrDefault(b => b.Id == bookId);
            var member = members.FirstOrDefault(m => m.Id == memberId);
            var transaction = transactions.FirstOrDefault(t => t.BookId == bookId && t.MemberId == memberId && t.ReturnDate == null);

            if (book != null && member != null && transaction != null)
            {
                book.IsBorrowed = false;
                member.BorrowedBookIds.Remove(bookId);
                transaction.ReturnDate = DateTime.Now;
            }
        }

        public List<Transaction> GetAllTransactions()
        {
            return transactions;
        }

        #endregion
    }
}
