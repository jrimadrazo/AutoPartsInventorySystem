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
    /// Interaction logic for SuppliersPage.xaml
    /// </summary>
    public partial class SuppliersPage : Window
    {
        public SuppliersPage()
        {
            InitializeComponent();
            this.DataContext = ViewModelLocator.SupplierViewModel;
        }

        private void btnAddSupplierWindow_Click(object sender, RoutedEventArgs e)
        {
            var aswindow = new AddSupplierWindow();
            aswindow.Show();
            this.Close();
        }

        private void btnEditSupplierWindow_Click(object sender, RoutedEventArgs e)
        {
            var eswindow = new EditSupplierWindow();
            eswindow.Show();
            this.Close();
        }

        private void btnDeleteSupplierWindow_Click(object sender, RoutedEventArgs e)
        {
            ViewModelLocator.SupplierViewModel.DeleteSupplier(ViewModelLocator.SupplierViewModel.SelectedSupplier.SupplierID);
            ViewModelLocator.SupplierViewModel.CreateSupplierList();
        }

        private void btnReturnSupplierWindow_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
