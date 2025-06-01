using System;
using System.Windows;
using System.Windows.Controls;
using System.Linq;


namespace JewelryShop.Pages
{
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            AuthPanel.Visibility = Visibility.Collapsed;
            RegPanel.Visibility = Visibility.Visible;
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            try { 
                string login = LoginBox.Text.Trim();
                string pass = PasswordBox.Text.Trim();

                if (login == "" || pass == "")
                {
                    MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                var user = (from u in gVars.entities.Users where u.Login == login select u).FirstOrDefault();
                if (user != null && pass == user.Password) {
                    MessageBox.Show("Вход успешно выполнен!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                    gVars.cur_user = user;
                    gVars.MainWindow.SetAuthorizedUI(true);
                    NavigationService?.Navigate(new Pages.SalesPage());
                }
                else
                {
                    MessageBox.Show("Невеный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Невеный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            string fullName = FullNameBox.Text.Trim();
            string login = RegLoginBox.Text.Trim();
            string password = RegPasswordBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (gVars.entities.Users.Any(u => u.Login == login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                var newUser = new Users
                {
                    FullName = fullName,
                    Login = login,
                    Password = password,
                    Role = "Продавец"
                };

                gVars.entities.Users.Add(newUser);
                gVars.entities.SaveChanges();

                MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                RegPanel.Visibility = Visibility.Collapsed;
                AuthPanel.Visibility = Visibility.Visible;

                LoginBox.Text = login;
                PasswordBox.Text = password;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void BackToAuth_Click(object sender, RoutedEventArgs e)
        {
            RegPanel.Visibility = Visibility.Collapsed;
            AuthPanel.Visibility = Visibility.Visible;
        }
    }
}
