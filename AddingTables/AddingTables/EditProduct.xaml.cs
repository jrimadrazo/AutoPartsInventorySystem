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

namespace AddingTables
{
    /// <summary>
    /// Interaction logic for EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void btnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            var pnname = tbxEditProductName.Text;
            var pntype = tbxEditProductType.Text;
            var pnquantity = tbxEditQuantity.Text;

            string pncolor;
            if (tbxEditColor.Text == "")
                pncolor = "N/A";
            else
                pncolor = tbxEditColor.Text;

            var pnbuyp = tbxEditBuyPrice.Text;
            var pnsellp = tbxEditSellPrice.Text;

            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void btnCancelEditProduct_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
    }
}
