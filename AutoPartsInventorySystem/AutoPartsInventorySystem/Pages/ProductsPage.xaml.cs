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
    /// Interaction logic for ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Window
    {
        public ProductsPage()
        {
            InitializeComponent();
            this.DataContext = ViewModelLocator.ProductViewModel;
        }

        private void btnAddProductWindow_Click(object sender, RoutedEventArgs e)
        {
            var apwindow = new AddProductWindow();
            apwindow.Show();
            this.Close();
        }

        private void btnEditProductWindow_Click(object sender, RoutedEventArgs e)
        {
            var epwindow = new EditProductWindow();
            epwindow.Show();
            this.Close();
        }

        private void btnDeleteProductWindow_Click(object sender, RoutedEventArgs e)
        {
            ViewModelLocator.ProductViewModel.DeleteProduct(ViewModelLocator.ProductViewModel.SelectedProduct.ProductID);
            ViewModelLocator.ProductViewModel.CreateProductList();
        }

        private void btnReturnProductWindow_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
