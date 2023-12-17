using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsProject_Models.Models
{
    [Table("StudentCourse")]
    public class StudentCourse
    {
        [Key]
        public int StudentCourseID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int CourseID { get; set; }
        public User Student { get; set; }
        public Course Course { get; set; }
    }
}
