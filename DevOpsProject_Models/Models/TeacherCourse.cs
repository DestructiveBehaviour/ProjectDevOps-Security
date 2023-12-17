using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsProject_Models.Models
{
    [Table("TeacherCourse")]
    public class TeacherCourse
    {
        [Key]
        public int TeacherCourseID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int CourseID { get; set; }

        public User Teacher { get; set; }
        public Course Course { get; set; }

    }
}
