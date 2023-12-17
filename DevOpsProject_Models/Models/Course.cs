using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsProject_Models.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        [Required]
        public string CourseLanguage { get; set; }

        public List<StudentCourse> Students { get; set; }
        public List<TeacherCourse> Teachers { get; set; }

        public Course(string courseName, string courseDescription, string courseLanguage)
        {
            CourseName = courseName;
            CourseDescription = courseDescription;
            CourseLanguage = courseLanguage;
            Students = new List<StudentCourse>();
            Teachers = new List<TeacherCourse>();
        }

        public Course()
        {
        }
    }
    
}
