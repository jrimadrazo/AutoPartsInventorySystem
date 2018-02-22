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

namespace AutoPartsInventorySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOpenProductPage_Click(object sender, RoutedEventArgs e)
        {
            var opwindow = new ProductsPage();
            opwindow.Show();
            this.Close();
        }

        private void btnOpenSupplierPage_Click(object sender, RoutedEventArgs e)
        {
            var oswindow = new SuppliersPage();
            oswindow.Show();
            this.Close();
        }

        private void btnOpenOrderPage_Click(object sender, RoutedEventArgs e)
        {
            var oowindow = new OrdersPage();
            oowindow.Show();
            this.Close();
        }
    }
}
