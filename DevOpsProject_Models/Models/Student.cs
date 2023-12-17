using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsProject_Models.Models
{
    public class Student : User
    {
        public List<StudentCourse> Courses { get; set; }

        public Student(string userType, string firstName, string lastName, string email, string username, string password)
        : base( userType, firstName, lastName, email, username, password)
        {
            Courses = new List<StudentCourse>();
        }
    }
}
