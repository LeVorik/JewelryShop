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

namespace JewelryShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gVars.MainFrame = MainFrame;
            gVars.MainWindow = this;
            MainFrame.Navigate(new Pages.AuthPage());
        }
        public void SetAuthorizedUI(bool isAuthorized)
        {
            ProductsButton.Visibility = isAuthorized ? Visibility.Visible : Visibility.Collapsed;
            CustomersButton.Visibility = isAuthorized ? Visibility.Visible : Visibility.Collapsed;
            SalesButton.Visibility = isAuthorized ? Visibility.Visible : Visibility.Collapsed;
            ExitButton.Visibility = isAuthorized ? Visibility.Visible : Visibility.Hidden;
            AuthButton.Visibility = isAuthorized ? Visibility.Hidden : Visibility.Visible;
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.ProductPage());
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.CustomerPage());
        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.SalesPage());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            gVars.cur_user = null;
            SetAuthorizedUI(false);
            MainFrame.Navigate(new Pages.AuthPage());
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.AuthPage());
        }
    }
}
