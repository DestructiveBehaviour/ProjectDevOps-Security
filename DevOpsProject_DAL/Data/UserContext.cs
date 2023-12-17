using DevOpsProject_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsProject_DAL.Data
{
    public class UserContext
    {
        private static readonly UserContext _instance = new UserContext();

        public static UserContext Instance => _instance;

        private UserContext() { }

        private User _currentUser;

        public User CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                // Notify any subscribers or UI elements about the change if needed
                // You can use events or INotifyPropertyChanged here if necessary
            }
        }

    }
}
