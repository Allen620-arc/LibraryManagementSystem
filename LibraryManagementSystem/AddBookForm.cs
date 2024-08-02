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
    public partial class AddBookForm : Form
    {
        private Library library;

        public AddBookForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var book = new Book(Convert.ToInt32(txtID.Text), txtTitle.Text, txtAuthor.Text, txtISBN.Text);
            library.AddBook(book);
            MessageBox.Show("Book added successfully!");
            this.Close();
        }
    }
}
