using DevOpsProject;
using DevOpsProject_DAL;
using DevOpsProject_Models.Models;
using Microsoft.VisualStudio.ApplicationInsights.Extensibility.Implementation;
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

namespace DevOpsProject_WPF
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : Page
    {
        private string _errorMessage = string.Empty;
        private UserContext _uc;

        public event EventHandler LoggedIn;
        public string Errormessage { get { return _errorMessage; } set { _errorMessage = value; } } 
        public LoginControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            DatabaseOperations db = new DatabaseOperations();

            User user = db.GetUsers().Find(x => x.Username == username && x.Password == password);

            
            if (user != null)
            {
                Errormessage = string.Empty;
                LoggedIn?.Invoke(this, EventArgs.Empty);
                OnLoginSuccess(user);
            }
            else
            {
                Errormessage = "Incorrect username and password.";
            }
        }

        private void OnLoginSuccess(User user)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.ReceiveUser(user);
                mainWindow.ShowOverviewView();
            }
        }
    }
}
