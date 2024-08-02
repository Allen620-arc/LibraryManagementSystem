using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class AddMemberForm : Form
    {
        private Library library;

        public AddMemberForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var member = new Member(Convert.ToInt32(txtID.Text), txtName.Text, txtEmail.Text);
            library.AddMember(member);
            MessageBox.Show("Member added successfully!");
            this.Close();
        }
    }
}
