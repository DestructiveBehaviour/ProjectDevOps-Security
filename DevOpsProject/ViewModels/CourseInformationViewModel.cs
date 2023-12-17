using DevOpsProject_DAL;
using DevOpsProject_Models.Models;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DevOpsProject_WPF.ViewModels
{
    public class CourseInformationViewModel
    {
        private Course _course;
        private ObservableCollection<User> _teachers;
        private ObservableCollection<User> _teachersNot;

        private ObservableCollection<User> _students;
        private ObservableCollection<User> _studentsNot;
        private User _teacherToAdd;
        private User _studentToAdd;
        private User _studentToRemove;
        private User _teacherToRemove;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand RegisterTeacher { get; }
        public ICommand RemoveTeacher { get; }
        public ICommand RegisterStudent { get; }
        public ICommand RemoveStudent { get; }


        public User TeacherToAdd { get { return _teacherToAdd; } set { _teacherToAdd = value; } }
        public User TeacherToRemove { get { return _teacherToRemove; } set { _teacherToRemove = value; } }
        public User StudentToAdd { get { return _studentToAdd; } set { _studentToAdd = value; } }
        public User StudentToRemove { get { return _studentToRemove; } set { _studentToRemove = value; } }

        private readonly DatabaseOperations _db = new DatabaseOperations();
        public ObservableCollection<User> Teachers { get { return _teachers; } set { _teachers = value; OnPropertyChanged(nameof(Teachers)); } }
        public ObservableCollection<User> TeachersNot { get { return _teachersNot; } set { _teachersNot = value; OnPropertyChanged(nameof(TeachersNot)); } }
        public ObservableCollection<User> Students { get { return _students; } set { _students = value; OnPropertyChanged(nameof(Students)); } }
        public ObservableCollection<User> StudentsNot { get { return _studentsNot; } set { _studentsNot = value; OnPropertyChanged(nameof(StudentsNot));  } }
        public Course Course { get { return _course; } set {_course = value; } }
        public CourseInformationViewModel(Course course)
        {
            Course = course;
            RetrieveLists();
            RegisterTeacher = new DelegateCommand(AddTeacherToCourse);
            RemoveTeacher = new DelegateCommand(RemoveTeacherFromCourse);
            RegisterStudent = new DelegateCommand(AddStudentToCourse);
            RemoveStudent = new DelegateCommand(RemoveStudentFromCourse);

        }

        public void RetrieveLists()
        {
            Teachers = new ObservableCollection<User>(_db.GetTeachersForCourse(Course.CourseID));
            TeachersNot = new ObservableCollection<User>(_db.GetTeachersNotForCourse(Course.CourseID));
            Students = new ObservableCollection<User>(_db.GetStudentsInCourse(Course.CourseID));
            StudentsNot = new ObservableCollection<User>(_db.GetStudentsNotInCourse(Course.CourseID));
        }

        public void AddTeacherToCourse()
        {
            if(TeacherToAdd != null)
            {
                _db.AddTeacherToCourse(TeacherToAdd.UserID, Course.CourseID);
                RetrieveLists();
            }
        }
        public void RemoveTeacherFromCourse()
        {
            if(TeacherToRemove != null)
            {
                _db.RemoveTeacherFromCourse(TeacherToRemove.UserID, Course.CourseID);
                RetrieveLists();
            }
        }
        public void RemoveStudentFromCourse()
        {
            if (StudentToRemove != null)
            {
                _db.RemoveStudentFromCourse(StudentToRemove.UserID, Course.CourseID);
                RetrieveLists();
            }
        }

        public void AddStudentToCourse()
        {
            if (StudentToAdd != null)
            {
                _db.EnrollStudentInCourse(StudentToAdd.UserID, Course.CourseID);
                RetrieveLists();
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
