using StudyingProject.Windows;
using System.Text;
using System.Windows;
using StudyingProject.Pages;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudyingProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RunnerButton_Click(object sender, RoutedEventArgs e)
        {
            var contentWindow = new ContentWindow();
            contentWindow.MainContent.Content = new RegAsRunnerPage(); 
            contentWindow.Show();
            this.Close();
        }
    }
}