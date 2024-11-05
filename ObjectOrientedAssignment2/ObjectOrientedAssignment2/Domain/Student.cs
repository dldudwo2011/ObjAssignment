using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAssignment2.Domain
{
    public class Student
    {
        private string _studentID = string.Empty; // Camel Case preceded with underscore
        private string _firstName = "";

        public string StudentID // Pascal case
        {
            get
            {
                return _studentID;
            }
            set
            {
                _studentID = value;
            }
        }

        public string FirstName // Expression-Bodied Property Assessors
        {
            get => _firstName; // implementation can be made up of only a single statement
            set => _firstName = value;
        }

        public string LastName { get; set; } = string.Empty; // Auto-Implemented Property
        public string? Email { get; set; } // Nullable property

        // Constructor with parameters to initialize StudentID, FirstName, LastName, and Email
        public Student(string studentID, string firstName, string lastName, string? email)
        {
            _studentID = studentID;
            _firstName = firstName;
            LastName = lastName;
            Email = email;
        }

        // Default constructor if needed
        public Student()
        {
            // Default constructor logic (if any)
        }
    }
}
