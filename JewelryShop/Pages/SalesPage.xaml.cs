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
    /// Логика взаимодействия для SalesPage.xaml
    /// </summary>
    public partial class SalesPage : Page
    {
        public SalesPage()
        {
            InitializeComponent();
            LoadSales();
        }
        private void LoadSales()
        {
            // Для примера загружаем продажи с покупателями и вычисляем сумму
            var sales = gVars.entities.Sales
                .Select(s => new
                {
                    s.Id,
                    s.SaleDate,
                    Customer = s.Customers.FullName,
                    Total = s.SaleItems.Sum(i => i.Quantity * i.Products.Price)
                }).ToList();

            SalesGrid.ItemsSource = sales;
        }

        private void AddSale_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaleDialog();
            if (dialog.ShowDialog() == true)
            {
                var sale = new Sales
                {
                    CustomerId = dialog.CustomerId,
                    SaleDate = dialog.SaleDate
                };
                gVars.entities.Sales.Add(sale);
                gVars.entities.SaveChanges();

                foreach (var item in dialog.SaleItems)
                {
                    var saleItem = new SaleItems
                    {
                        SaleId = sale.Id,
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        Price = item.Price
                    };
                    gVars.entities.SaleItems.Add(saleItem);
                }

                gVars.entities.SaveChanges();
                LoadSales();
            }
        }

    }
}
