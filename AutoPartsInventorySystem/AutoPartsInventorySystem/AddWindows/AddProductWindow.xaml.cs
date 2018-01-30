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
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            var pname = tbxProductName.Text;
            var ptype = tbxProductType.Text;
            int pquantity = Convert.ToInt16(tbxQuantity.Text);
            var pcolor = tbxColor.Text;
            int pbuyp = Convert.ToInt16(tbxBuyingPrice.Text);
            int psellp = Convert.ToInt16(tbxSellingPrice.Text);

            ViewModelLocator.ProductViewModel.AddProduct(pname, ptype, pquantity, pcolor, pbuyp, psellp);
            ViewModelLocator.ProductViewModel.CreateProductList();

            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void btnCancelAddProduct_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
