using System;
using System.Collections.Generic;
using System.IO;
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
using JewelryShop.Pages;

namespace JewelryShop.ModalViews
{
    /// <summary>
    /// Логика взаимодействия для ProductDialog.xaml
    /// </summary>
    public partial class ProductDialog : Window
    {
        public Products Product { get; private set; }

        public ProductDialog(Products product = null)
        {
            InitializeComponent();

            if (product != null)
            {
                Product = product;
                NameBox.Text = product.Name;
                CategoryBox.Text = product.Category;
                MaterialBox.Text = product.Material;
                PurityBox.Text = product.Purity;
                WeightBox.Text = product.Weight?.ToString();
                PriceBox.Text = product.Price?.ToString();
            }
            else
            {
                Product = new Products();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(CategoryBox.Text) ||
                string.IsNullOrWhiteSpace(MaterialBox.Text) ||
                string.IsNullOrWhiteSpace(PurityBox.Text) ||
                string.IsNullOrWhiteSpace(WeightBox.Text) ||
                string.IsNullOrWhiteSpace(PriceBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Проверка, что вес и цена — допустимые числа
            if (!decimal.TryParse(WeightBox.Text, out decimal weight) || weight <= 0)
            {
                MessageBox.Show("Введите корректный вес (положительное число).", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!decimal.TryParse(PriceBox.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену (положительное число).", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Присваиваем значения
            Product.Name = NameBox.Text;
            Product.Category = CategoryBox.Text;
            Product.Material = MaterialBox.Text;
            Product.Purity = PurityBox.Text;
            Product.Weight = weight;
            Product.Price = price;

            DialogResult = true;
            Close();
        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
