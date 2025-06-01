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
using JewelryShop.ModalViews;

namespace JewelryShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        public CustomerPage()
        {
            InitializeComponent();

            if (gVars.cur_user.Role == "Администратор")
            {
                AddButton.Visibility = Visibility.Visible;
                EditButton.Visibility = Visibility.Visible;
                DelButton.Visibility = Visibility.Visible;
            }
            else
            {
                AddButton.Visibility = Visibility.Hidden;
                EditButton.Visibility = Visibility.Hidden;
                DelButton.Visibility = Visibility.Hidden;
            }
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            CustomersGrid.ItemsSource = gVars.entities.Customers.ToList();
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CustomerDialog();
            if (dialog.ShowDialog() == true)
            {
                var customer = new Customers
                {
                    FullName = dialog.FullName,
                    Phone = dialog.Phone
                };
                gVars.entities.Customers.Add(customer);
                gVars.entities.SaveChanges();
                LoadCustomers();
            }
        }

        private void EditCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (CustomersGrid.SelectedItem is Customers selected)
            {
                var dialog = new CustomerDialog(selected);
                if (dialog.ShowDialog() == true)
                {
                    selected.FullName = dialog.FullName;
                    selected.Phone = dialog.Phone;
                    gVars.entities.SaveChanges();
                    LoadCustomers();
                }
            }
            else
            {
                MessageBox.Show("Выберите покупателя для редактирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var customer = CustomersGrid.SelectedItem as Customers;
            if (customer == null)
            {
                MessageBox.Show("Выберите покупателя для удаления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (MessageBox.Show($"Удалить покупателя {customer.FullName}?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.No) return;
            
            if (gVars.entities.Sales.Any(x => x.CustomerId== customer.Id))
            {
                MessageBox.Show("У покупателя имеется запись в продажах", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            gVars.entities.Customers.Remove(customer);
            gVars.entities.SaveChanges();
            LoadCustomers();
        }
    }
}
