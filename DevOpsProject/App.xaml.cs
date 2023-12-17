using DevOpsProject_DAL.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DevOpsProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            InitializeDatabase();

        }

        private void InitializeDatabase()
        {
            using (var dbContext = new ProjectContext())
            {
                dbContext.Database.EnsureCreated();
            }
        }
    }
}
