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

namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttonLoginClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Авторизация в приложении находится в разработке!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void hyperlinkLoginGuestClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }
        private void hyperlinkRegistrationClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Регистрация в приложении находится в разработке!", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
