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
    public partial class BorrowBookForm : Form
    {
        private Library library;

        public BorrowBookForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(txtBookID.Text);
            int memberId = Convert.ToInt32(txtMemberID.Text);

            library.BorrowBook(bookId, memberId);
            MessageBox.Show("Book borrowed successfully!");
            this.Close();
        }
    }
}
