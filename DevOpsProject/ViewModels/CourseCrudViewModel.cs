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
    public class CourseCrudViewModel : BaseViewModel
    {
        private Course _course;
        private readonly DatabaseOperations _db = new DatabaseOperations();
        private string _name;
        private string _description;
        private string _language;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name)); // Implement INotifyPropertyChanged
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description)); // Implement INotifyPropertyChanged
            }
        }
        public string Language
        {
            get { return _language; }
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language)); // Implement INotifyPropertyChanged
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand CreateAndUpdateCourseCommand { get; }

        public Course Course { get { return _course; } set { _course = value; } }

        public CourseCrudViewModel()
        {
            CreateAndUpdateCourseCommand = new DelegateCommand(CreateAndUpdateCourse);
        }

        public CourseCrudViewModel(Course course)
        {
            Course = course;
            CreateAndUpdateCourseCommand = new DelegateCommand(CreateAndUpdateCourse);
        }


        public void CreateAndUpdateCourse()
        {
            if (Course != null && Course.CourseID > 0) 
            {
                Course.CourseName = Name;
                Course.CourseDescription = Description;
                Course.CourseLanguage = Language;
                _db.UpdateCourse(Course); 
            }
            else
            {
                Course newCourse = new Course()
                {
                    CourseName = Name,
                    CourseDescription = Description,
                    CourseLanguage = Language
                };
                if (!string.IsNullOrWhiteSpace(newCourse.CourseName) && !string.IsNullOrWhiteSpace(newCourse.CourseLanguage))
                {
                    _db.CreateCourse(newCourse); 
                }
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
