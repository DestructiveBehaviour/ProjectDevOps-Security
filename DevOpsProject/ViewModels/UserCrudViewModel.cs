using DevOpsProject_DAL;
using DevOpsProject_Models.Models;
using DevOpsProject_WPF.Views;
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
    public class UserCrudViewModel : BaseViewModel
    {
        private User _user;
        private ObservableCollection<Course> _courses;
        private readonly DatabaseOperations _db = new DatabaseOperations();
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private string _username;
        private string _userType;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName)); // Implement INotifyPropertyChanged
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email)); // Implement INotifyPropertyChanged
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password)); // Implement INotifyPropertyChanged
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username)); // Implement INotifyPropertyChanged
            }
        }
        public string UserType
        {
            get { return _userType; }
            set
            {
                _userType = value;
                OnPropertyChanged(nameof(UserType)); // Implement INotifyPropertyChanged
            }
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName)); // Implement INotifyPropertyChanged
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand CreateAndUpdateCommand { get; }
        public ObservableCollection<Course> Courses { get { return _courses; } set { _courses = value; } }
        public User User { get { return _user; } set { _user = value; } }
        public UserCrudViewModel(User user)
        {
            User = user;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            UserType = user.UserType;
            Password = user.Password;
            Email = user.Email;
            
            RetrieveLists();
            CreateAndUpdateCommand = new DelegateCommand(CreateAndUpdateUser);
        }

        public UserCrudViewModel() 
        {
            CreateAndUpdateCommand = new DelegateCommand(CreateAndUpdateUser);
        }

        public void RetrieveLists()
        {
            if(User.UserType == "Teacher")
            {
                Courses = new ObservableCollection<Course>(_db.GetCoursesForTeacher(User.UserID));
            }
            else if (User.UserType == "Student")
            {
                Courses = new ObservableCollection<Course>(_db.GetCoursesForStudent(User.UserID));
            }
        }

        public void CreateAndUpdateUser()
        {
            if (User != null && User.UserID > 0) // Check if the user exists and has a valid UserID
            {
                User.FirstName = FirstName;
                User.LastName = LastName;
                User.Email = Email;
                User.Password = Password;
                User.UserType = UserType;
                User.Username = Username;
                _db.UpdateUser(User); // Update the existing user
            }
            else
            {
                User newUser = new User()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Email = Email,
                    Password = Password,
                    UserType = UserType,
                    Username = Username
                };
                if (!string.IsNullOrWhiteSpace(newUser.Username) && !string.IsNullOrWhiteSpace(newUser.Password))
                {
                    _db.CreateUser(newUser); // Create a new user if username and password are not empty
                }
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
