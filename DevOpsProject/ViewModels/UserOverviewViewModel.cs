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
using System.Windows.Controls;
using System.Windows.Input;

namespace DevOpsProject_WPF.ViewModels
{
    public class UserOverviewViewModel : BaseViewModel
    {
        private readonly DatabaseOperations _db = new DatabaseOperations();
        private User _selectedUser = null;
        public event PropertyChangedEventHandler PropertyChanged;
        private Frame _mainFrame;
        public ICommand ShowUserInfoCommand { get; }
        public ICommand CreateNewUserCommand { get; }
        public ICommand DeleteSelectedCommand { get; }

        public ObservableCollection<User> Users { get; set; }



        public UserOverviewViewModel(Frame mainFrame)
        {
            _mainFrame = mainFrame;
            ShowUserInfoCommand = new DelegateCommand(ShowInfo);
            CreateNewUserCommand = new DelegateCommand(CreateUser);
            DeleteSelectedCommand = new DelegateCommand(DeleteUser);
            Users = new ObservableCollection<User>(_db.GetUsers());
        }

        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged(nameof(SelectedUser));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ShowInfo()
        {
            if(SelectedUser != null)
            {
                UserCrudViewModel viewModel = new UserCrudViewModel(SelectedUser);
                UserCrudView userCrudView = new UserCrudView()
                {
                    DataContext = viewModel
                };

                _mainFrame.Navigate(userCrudView);
            }
        }

        public void CreateUser()
        {
            UserCrudViewModel viewModel = new UserCrudViewModel();
            UserCrudView userCrudView = new UserCrudView()
            {
                DataContext = viewModel
            };

            _mainFrame.Navigate(userCrudView);
        }

        public void DeleteUser()
        {
            if(SelectedUser != null)
            {
                _db.DeleteUser(SelectedUser.UserID);
                Users = new ObservableCollection<User>(_db.GetUsers());
            }
        }

    }
}
