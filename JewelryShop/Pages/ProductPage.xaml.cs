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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            LoadProducts();
        }
        private void LoadProducts()
        {
            ProductsGrid.ItemsSource = gVars.entities.Products.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ProductDialog();
            if (dialog.ShowDialog() == true)
            {
                var newProduct = new Products
                {
                    Name = dialog.NameBox.Text,
                    Category = dialog.CategoryBox.Text,
                    Price = Convert.ToDecimal(dialog.PriceBox.Text)
                };
                gVars.entities.Products.Add(newProduct);
                gVars.entities.SaveChanges();
                LoadProducts();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsGrid.SelectedItem is Products selected)
            {
                var dialog = new ProductDialog(selected);
                if (dialog.ShowDialog() == true)
                {
                    selected.Name = dialog.NameBox.Text;
                    selected.Category = dialog.CategoryBox.Text;
                    selected.Price = Convert.ToDecimal(dialog.PriceBox.Text);

                    gVars.entities.SaveChanges();
                    LoadProducts();
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для редактирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var product = ProductsGrid.SelectedItem as Products;
            if (product == null)
            {
                MessageBox.Show("Выберите продукт для удаления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (MessageBox.Show($"Удалить продукт {product.Name}?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.No) return;

            if (gVars.entities.SaleItems.Any(x => x.ProductId == product.Id))
            {
                MessageBox.Show("У товара есть запись в продажах", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            gVars.entities.Products.Remove(product);
            gVars.entities.SaveChanges();
            LoadProducts();
        }
    }
}
