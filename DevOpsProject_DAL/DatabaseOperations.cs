using DevOpsProject_DAL.Data;
using DevOpsProject_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsProject_DAL
{
    public class DatabaseOperations
    {
        #region Users

        #region Get
        public List<User> GetUsers()
        {
            using (ProjectContext pc = new ProjectContext())
            {
                return pc.Users.ToList();
            }
        }


        public List<User> GetStudentsInCourse(int id)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                var studentsInCourse = pc.StudentCourses
            .Where(sc => sc.CourseID == id)
            .Select(sc => sc.Student)
            .ToList();

                return studentsInCourse;
            }
        }

        public List<User> GetStudentsNotInCourse(int id)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                var studentsInCourse = pc.StudentCourses
            .Where(sc => sc.CourseID == id)
            .Select(sc => sc.Student)
            .ToList();

                var allStudents = pc.Users.Where(u => u.UserType == "Student").ToList(); 

                var studentsNotInCourse = allStudents.Except(studentsInCourse).ToList();

                return studentsNotInCourse;
            }
        }

        public List<User> GetTeachersForCourse(int id)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                var teachersForCourse = pc.TeacherCourses.Where(tc => tc.CourseID == id).Select(tc => tc.Teacher).ToList();
                return teachersForCourse;
            }
        }

        public List<User> GetTeachersNotForCourse(int id)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                var teachersForCourse = pc.TeacherCourses.Where(tc => tc.CourseID == id).Select(tc => tc.Teacher).ToList();

                var allTeachers = pc.Users.Where(u => u.UserType == "Teacher").ToList();
                var teachersNotForCourse = allTeachers.Except(teachersForCourse).ToList();

                return teachersNotForCourse;
            }
        }
        #endregion

        #region Create

        public bool CreateUser(User user)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                List<User> exists = pc.Users.Where(x => x.Username == user.Username).ToList();

                if (exists.Count() == 0)
                {
                    pc.Users.Add(user);
                    pc.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        #endregion

        #region update

        public bool UpdateUser<T>(T user) where T : User
        {
            using (ProjectContext pc = new ProjectContext())
            {
                var existingUser = pc.Users.Find(user.UserID);

                if (existingUser != null && existingUser.GetType() == typeof(T))
                {
                    pc.Entry(existingUser).CurrentValues.SetValues(user);
                    pc.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        #endregion

        #region Delete

        public bool DeleteUser(int id)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                if (pc.Users.Find(id) != null)
                {
                    pc.Users.Entry(pc.Users.Find(id)!).State = EntityState.Deleted;
                    pc.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        #endregion

        #endregion

        #region Course

        #region Get
        public List<Course> GetCourses()
        {
            using (ProjectContext pc = new ProjectContext())
            {
                try
                {
                    List<Course> courses = pc.Courses.ToList();
                    return courses;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching courses: {ex.Message}");
                    throw; 
                }
            }
        }

        public List<Course> GetCoursesForStudent(int id)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                return pc.Courses.Include(x => x.Students).ThenInclude(x=>x.Student).ToList().Where(x=>x.Students.Any(x=>x.UserID == id)).ToList();
            }
        }

        public List<Course> GetCoursesForTeacher(int id)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                return pc.Courses.Include(x => x.Teachers).ThenInclude(x => x.Teacher).ToList().Where(x => x.Teachers.Any(x => x.UserID == id)).ToList();
            }
        }
        #endregion

        #region Create
        public bool CreateCourse(Course course)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                List<Course> exists = new List<Course>();
                exists = pc.Courses.Where(x => x.CourseName == course.CourseName && x.CourseLanguage == course.CourseLanguage).ToList();

                if (exists.Count() == 0)
                {
                    pc.Courses.Add(course);
                    pc.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        #endregion

        #region Update

        public bool UpdateCourse(Course course)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                if (pc.Courses.Find(course.CourseID) != null)
                {
                    pc.Courses.Entry(course).State = EntityState.Modified;
                    pc.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        #endregion

        #region Delete

        public bool DeleteCourse(int id)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                if (pc.Courses.Find(id) != null)
                {
                    pc.Courses.Entry(pc.Courses.Find(id)!).State = EntityState.Deleted;
                    pc.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        #endregion

        #endregion

        #region Enrollment

        public bool EnrollStudentInCourse(int userId, int courseId)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                try
                {
                    var existingEnrollment = pc.StudentCourses
                                                .FirstOrDefault(sc => sc.UserID == userId && sc.CourseID == courseId);

                    if (existingEnrollment != null)
                    {
                        return false;
                    }

                    StudentCourse newEnrollment = new StudentCourse
                    {
                        UserID = userId,
                        CourseID = courseId
                    };

                    pc.StudentCourses.Add(newEnrollment);
                    pc.SaveChanges();

                    return true; 
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool AddTeacherToCourse(int userId, int courseId)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                try
                {
                    var existingEnrollment = pc.TeacherCourses
                                                .FirstOrDefault(sc => sc.UserID == userId && sc.CourseID == courseId);

                    if (existingEnrollment != null)
                    {
                        return false;
                    }

                    TeacherCourse newEnrollment = new TeacherCourse
                    {
                        UserID = userId,
                        CourseID = courseId
                    };

                    pc.TeacherCourses.Add(newEnrollment);
                    pc.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool RemoveStudentFromCourse(int userId, int courseId)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                try
                {
                    var enrollmentToRemove = pc.StudentCourses
                                                .FirstOrDefault(sc => sc.UserID == userId && sc.CourseID == courseId);

                    if (enrollmentToRemove == null)
                    {
                        return false;
                    }

                    pc.StudentCourses.Remove(enrollmentToRemove);
                    pc.SaveChanges();

                    return true; 
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool RemoveTeacherFromCourse(int userId, int courseId)
        {
            using (ProjectContext pc = new ProjectContext())
            {
                try
                {
                    var TeacherToRemove = pc.TeacherCourses
                                                .FirstOrDefault(sc => sc.UserID == userId && sc.CourseID == courseId);

                    if (TeacherToRemove == null)
                    {
                        return false;
                    }

                    pc.TeacherCourses.Remove(TeacherToRemove);
                    pc.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }


        #endregion
    }
}
