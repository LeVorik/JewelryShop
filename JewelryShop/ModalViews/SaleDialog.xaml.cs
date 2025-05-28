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
    /// Логика взаимодействия для SaleDialog.xaml
    /// </summary>
    public class SaleItemViewModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
        public Products Product { get; set; }
    }

    public partial class SaleDialog : Window
    {
        private Entities entities = new Entities();
        public int CustomerId { get; private set; }
        public DateTime SaleDate { get; private set; }
        public List<SaleItemViewModel> SaleItems { get; private set; } = new List<SaleItemViewModel>();

        public SaleDialog()
        {
            InitializeComponent();
            CustomerBox.ItemsSource = entities.Customers.ToList();
            DatePicker.SelectedDate = DateTime.Today;

            var products = entities.Products.ToList();
            ItemsGrid.ItemsSource = new List<SaleItemViewModel> { new SaleItemViewModel() };
            ((DataGridComboBoxColumn)ItemsGrid.Columns[0]).ItemsSource = products;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerBox.SelectedItem is Customers customer && DatePicker.SelectedDate.HasValue)
            {
                CustomerId = customer.Id;
                SaleDate = DatePicker.SelectedDate.Value;

                var items = ItemsGrid.ItemsSource.Cast<SaleItemViewModel>()
                              .Where(i => i.ProductId > 0 && i.Quantity > 0)
                              .ToList();

                if (items.Count == 0)
                {
                    MessageBox.Show("Добавьте хотя бы один товар.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                SaleItems = items;
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Укажите покупателя и дату.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ItemsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ItemsGrid.CurrentItem is SaleItemViewModel item)
            {
                var selectedRow = ItemsGrid.SelectedItem as SaleItemViewModel;
                if (selectedRow != null)
                {
                    var rowIndex = ItemsGrid.Items.IndexOf(selectedRow);
                    var row = ItemsGrid.Columns[0].GetCellContent(selectedRow)?.Parent as DataGridRow;
                    if (row != null)
                    {
                        var productColumn = (DataGridComboBoxColumn)ItemsGrid.Columns[0];
                        var comboBox = productColumn.GetCellContent(row) as ComboBox;
                        if (comboBox != null && comboBox.SelectedItem is Products product)
                        {
                            selectedRow.Price = Convert.ToDecimal(product.Price); // подстановка цены
                            selectedRow.Product = product;
                            ItemsGrid.Items.Refresh(); // обновить отображение
                        }
                    }
                }
            }
        }

    }
}
