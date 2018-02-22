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

namespace AutoPartsInventorySystem
{
    /// <summary>
    /// Interaction logic for OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Window
    {
        public OrdersPage()
        {
            InitializeComponent();
            this.DataContext = ViewModelLocator.OrderViewModel;
        }

        private void btnAddOrderWindow_Click(object sender, RoutedEventArgs e)
        {
            var aowindow = new AddOrderWindow();
            aowindow.Show();
            this.Close();
        }

        private void btnEditOrderWindow_Click(object sender, RoutedEventArgs e)
        {
            var eowindow = new EditOrderWindow();
            eowindow.Show();
            this.Close();
        }

        private void btnDeleteOrderWindow_Click(object sender, RoutedEventArgs e)
        {
            ViewModelLocator.OrderViewModel.DeleteOrder(ViewModelLocator.OrderViewModel.SelectedOrder.OrderID);
            ViewModelLocator.OrderViewModel.CreateOrderList();
        }

        private void btnReturnOrderWindow_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
