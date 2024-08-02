using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LibraryForm : Form
    {
        private Library library;

        public LibraryForm()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm(library);
            addBookForm.ShowDialog();
        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            var addMemberForm = new AddMemberForm(library);
            addMemberForm.ShowDialog();
        }

        private void BorrowBook_Click(object sender, EventArgs e)
        {
            var borrowBookForm = new BorrowBookForm(library);
            borrowBookForm.ShowDialog();
        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {
            var returnBookForm = new ReturnBookForm(library);
            returnBookForm.ShowDialog();
        }

        private void ViewBooks_Click(object sender, EventArgs e)
        {
            var viewBooksForm = new ViewBooksForm(library);
            viewBooksForm.ShowDialog();
        }
    }
}
