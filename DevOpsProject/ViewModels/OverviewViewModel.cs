using DevOpsProject;
using DevOpsProject_DAL;
using DevOpsProject_DAL.Data;
using DevOpsProject_Models.Models;
using DevOpsProject_WPF.Views;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DevOpsProject_WPF.ViewModels
{
    public class OverviewViewModel : BaseViewModel
    {
        private readonly DatabaseOperations _db = new DatabaseOperations();
        private Course _selectedCourse = null;
        public event PropertyChangedEventHandler PropertyChanged;
        private Frame _mainFrame;
        private User _user;
        private string _fetch = "Courses";
        
        public Course SelectedCourse
        {
            get { return _selectedCourse; }
            set
            {
                _selectedCourse = value;
                OnPropertyChanged(nameof(Course));
            }
        }
        public ObservableCollection<Course> Courses { get; set; }
        public Course NewCourse { get; set; } // If you need to create a new course

        public ICommand CreateNewCourseCommand { get; }
        public ICommand ShowCourseInfoCommand { get; }
        public ICommand DeleteSelectedCommand { get; }


        public OverviewViewModel(Frame mainFrame)
        {
            _user = UserContext.Instance.CurrentUser;
            _mainFrame = mainFrame;
            CreateNewCourseCommand = new DelegateCommand(CreateCourse);
            ShowCourseInfoCommand = new DelegateCommand(ShowInfo);
            DeleteSelectedCommand = new DelegateCommand(DeleteCourse);
            // Initialize collections or properties
            Courses = new ObservableCollection<Course>(_db.GetCourses());
            NewCourse = new Course(); // Initialize a new course object
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ShowInfo()
        {
            if (SelectedCourse != null)
            {
                CourseInformationViewModel viewModel = new CourseInformationViewModel(SelectedCourse);
                CourseInformationView courseInformationView = new CourseInformationView
                {
                    DataContext = viewModel
                };

                _mainFrame.Navigate(courseInformationView);
            }
        }

        public void CreateCourse()
        {
            CourseCrudViewModel viewModel = new CourseCrudViewModel();
            CourseCrudView courseCrudView = new CourseCrudView()
            {
                DataContext = viewModel
            };

            _mainFrame.Navigate(courseCrudView);
        }

        public void DeleteCourse()
        {
            if(SelectedCourse != null)
            {
                _db.DeleteCourse(SelectedCourse.CourseID);
            }
        }
    }
}
