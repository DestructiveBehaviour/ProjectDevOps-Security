using DevOpsProject_DAL.Data;
using DevOpsProject_Models.Models;
using DevOpsProject_WPF;
using DevOpsProject_WPF.ViewModels;
using DevOpsProject_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DevOpsProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isLoggedIn = true;
        private User _user;
        private string _name = string.Empty;

        public string Name { get { return _name; } set { _name = value; } }
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
            }
        }
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set
            {
                isLoggedIn = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new LoginControl();
            this.DataContext = this;
        }


        private void GoToCourseOverview_Click(object sender, RoutedEventArgs e)
        {
            OverviewView overviewView = new OverviewView(MainFrame); // Instantiate the view
            overviewView.DataContext = new OverviewViewModel(MainFrame); // Set ViewModel as DataContext
            MainFrame.Navigate(overviewView); // Navigate to OverviewView
        }
        private void GoToUserOverview_Click(object sender, RoutedEventArgs e)
        {
            UserOverview useroverview = new UserOverview(MainFrame); // Instantiate the view
            useroverview.DataContext = new UserOverviewViewModel(MainFrame); // Set ViewModel as DataContext
            MainFrame.Navigate(useroverview); // Navigate to OverviewView
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            User = null;
            IsLoggedIn = true;
            // Switch to the login screen
            SwitchToLoginScreen();
        }

        public void SwitchToLoginScreen()
        {
            MainFrame.Content = new LoginControl(); // Replace LoginScreen with your UserControl for the login screen
        }

        private void OnLoginSuccess(object sender, EventArgs e)
        {
            IsLoggedIn = false;
            // Switch to the OverviewView upon successful login
            MainFrame.Navigate(new OverviewView(MainFrame));
        }

        public void ReceiveUser(User user)
        {
            User = user;
            UserContext.Instance.CurrentUser = User;
        }

        // Method to show OverviewView in MainFrame
        public void ShowOverviewView()
        {
            // Show the OverviewView in the MainFrame here
            // For example:
            this.MainFrame.Navigate(new OverviewView(MainFrame));
        }
    }
}
