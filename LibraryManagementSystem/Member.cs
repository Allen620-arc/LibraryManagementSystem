using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Member
    {
        public int Id { get; set; }                // Unique identifier for the member
        public string Name { get; set; }           // Name of the member
        public string Email { get; set; }          // Email address of the member
        public List<int> BorrowedBookIds { get; set; }  // List of book IDs currently borrowed by the member

        public Member(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            BorrowedBookIds = new List<int>();    // Initialize the list of borrowed book IDs
        }
    }
}
