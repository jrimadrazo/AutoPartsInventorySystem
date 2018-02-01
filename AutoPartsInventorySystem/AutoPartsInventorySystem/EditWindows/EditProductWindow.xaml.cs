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
    /// Interaction logic for EditProductWindow.xaml
    /// </summary>
    public partial class EditProductWindow : Window
    {
        public EditProductWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModelLocator.ProductViewModel.SelectedProduct;
        }

        private void btnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            var pid = ViewModelLocator.ProductViewModel.SelectedProduct.ProductID;
            var pname = tbxEditProductName.Text;
            var ptype = tbxEditProductType.Text;
            int pquantity = Convert.ToInt16(tbxEditQuantity.Text);
            var pcolor = tbxEditColor.Text;
            int pbuyp = Convert.ToInt16(tbxEditBuyingPrice.Text);
            int psellp = Convert.ToInt16(tbxEditSellingPrice.Text);

            ViewModelLocator.ProductViewModel.EditProduct(pid, pname, ptype, pquantity, pcolor, pbuyp, psellp);
            ViewModelLocator.ProductViewModel.CreateProductList();

            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void btnCancelEditProduct_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
