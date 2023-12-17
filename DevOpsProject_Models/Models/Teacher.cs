using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsProject_Models.Models
{
    public class Teacher : User
    {
        public List<TeacherCourse> Courses { get; set; }

        public Teacher(string userType, string firstName, string lastName, string email, string username, string password)
        : base(userType, firstName, lastName, email, username, password)
        {
            Courses = new List<TeacherCourse>();
        }
    }
}
