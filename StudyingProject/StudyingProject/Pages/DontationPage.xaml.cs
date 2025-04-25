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

namespace StudyingProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для DontationPage.xaml
    /// </summary>
    public partial class DontationPage : Page
    {
        public DontationPage()
        {
            InitializeComponent();
        }

        private void plusButton_click(object sender, RoutedEventArgs e)
        {
            int MoneyAmount = Convert.ToInt32(MoneyText.Content.ToString().Trim('$')); 
            MoneyAmount += Convert.ToInt32(MoneyInputField.Text.ToString());
            MoneyText.Content = $"{MoneyAmount.ToString()}$";
        }
        private void minusButton_click(object sender, RoutedEventArgs e)
        {
            int MoneyAmount = Convert.ToInt32(MoneyText.Content.ToString().Trim('$'));
            int MinusMoneyAmount = Convert.ToInt32(MoneyInputField.Text.ToString());
            if (MoneyAmount-MinusMoneyAmount < 0)
                return;
            else
            {
                MoneyAmount -= MinusMoneyAmount;
                MoneyText.Content = $"{MoneyAmount.ToString()}$";
            }
        }
    }
}
