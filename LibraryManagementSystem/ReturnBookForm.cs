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
    public partial class ReturnBookForm : Form
    {
        private Library library;

        public ReturnBookForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(txtBookID.Text);
            int memberId = Convert.ToInt32(txtMemberID.Text);

            library.ReturnBook(bookId, memberId);
            MessageBox.Show("Book returned successfully!");
            this.Close();
        }
    }
}
