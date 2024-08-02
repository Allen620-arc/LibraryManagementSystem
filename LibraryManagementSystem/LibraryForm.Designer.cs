namespace LibraryManagementSystem
{
    partial class LibraryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewBooks = new System.Windows.Forms.Button();
            this.ReturnBook = new System.Windows.Forms.Button();
            this.BorrowBook = new System.Windows.Forms.Button();
            this.AddMember = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewBooks
            // 
            this.ViewBooks.Location = new System.Drawing.Point(12, 128);
            this.ViewBooks.Name = "ViewBooks";
            this.ViewBooks.Size = new System.Drawing.Size(280, 23);
            this.ViewBooks.TabIndex = 9;
            this.ViewBooks.Text = "View Books";
            this.ViewBooks.UseVisualStyleBackColor = true;
            this.ViewBooks.Click += new System.EventHandler(this.ViewBooks_Click);
            // 
            // ReturnBook
            // 
            this.ReturnBook.Location = new System.Drawing.Point(12, 99);
            this.ReturnBook.Name = "ReturnBook";
            this.ReturnBook.Size = new System.Drawing.Size(280, 23);
            this.ReturnBook.TabIndex = 8;
            this.ReturnBook.Text = "Return Book";
            this.ReturnBook.UseVisualStyleBackColor = true;
            this.ReturnBook.Click += new System.EventHandler(this.ReturnBook_Click);
            // 
            // BorrowBook
            // 
            this.BorrowBook.Location = new System.Drawing.Point(12, 70);
            this.BorrowBook.Name = "BorrowBook";
            this.BorrowBook.Size = new System.Drawing.Size(280, 23);
            this.BorrowBook.TabIndex = 7;
            this.BorrowBook.Text = "Borrow Book";
            this.BorrowBook.UseVisualStyleBackColor = true;
            this.BorrowBook.Click += new System.EventHandler(this.BorrowBook_Click);
            // 
            // AddMember
            // 
            this.AddMember.Location = new System.Drawing.Point(12, 41);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(280, 23);
            this.AddMember.TabIndex = 6;
            this.AddMember.Text = "Add Member";
            this.AddMember.UseVisualStyleBackColor = true;
            this.AddMember.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(12, 12);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(280, 23);
            this.AddBook.TabIndex = 5;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 167);
            this.Controls.Add(this.ViewBooks);
            this.Controls.Add(this.ReturnBook);
            this.Controls.Add(this.BorrowBook);
            this.Controls.Add(this.AddMember);
            this.Controls.Add(this.AddBook);
            this.Name = "LibraryForm";
            this.Text = "Library Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewBooks;
        private System.Windows.Forms.Button ReturnBook;
        private System.Windows.Forms.Button BorrowBook;
        private System.Windows.Forms.Button AddMember;
        private System.Windows.Forms.Button AddBook;
    }
}