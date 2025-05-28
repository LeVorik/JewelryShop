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

namespace JewelryShop.ModalViews
{
    /// <summary>
    /// Логика взаимодействия для CustomerDialog.xaml
    /// </summary>
    public partial class CustomerDialog : Window
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public CustomerDialog()
        {
            InitializeComponent();
        }

        public CustomerDialog(Customers customer) : this()
        {
            FullNameBox.Text = customer.FullName;
            PhoneBox.Text = customer.Phone;
            EmailBox.Text = customer.Email;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullNameBox.Text))
            {
                MessageBox.Show("ФИО обязательно.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            FullName = FullNameBox.Text.Trim();
            Phone = PhoneBox.Text.Trim();
            Email = EmailBox.Text.Trim();
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
