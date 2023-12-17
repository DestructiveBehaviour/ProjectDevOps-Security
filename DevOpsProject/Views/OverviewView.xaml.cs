using DevOpsProject;
using DevOpsProject_DAL.Data;
using DevOpsProject_Models.Models;
using DevOpsProject_WPF.ViewModels;
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
using System.Windows.Shapes;

namespace DevOpsProject_WPF.Views
{
    /// <summary>
    /// Interaction logic for OverviewView.xaml
    /// </summary>
    public partial class OverviewView : Page
    {
        private OverviewViewModel overviewViewModel;
        private Frame _mainFrame;
        
        public OverviewView(Frame mainFrame)
        {
            InitializeComponent();
            DataContext = new OverviewViewModel(mainFrame);
        }

        private void GoToCourseInfo_Click(object sender, RoutedEventArgs e)
        {
            Course selectedCourse = overviewViewModel.SelectedCourse;
            CourseInformationViewModel courseInfoViewModel = new CourseInformationViewModel(selectedCourse);
            CourseInformationView courseInfoView = new CourseInformationView
            {
                DataContext = courseInfoViewModel
            };

            // Navigate to CourseInformationView
            _mainFrame.Navigate(courseInfoView);
        }


    }
}
