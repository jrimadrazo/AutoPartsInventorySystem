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
    /// Interaction logic for AddSupplierWindow.xaml
    /// </summary>
    public partial class AddSupplierWindow : Window
    {
        public AddSupplierWindow()
        {
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            var sname = tbxSupplierName.Text;
            var sdetails = tbxSupplierDetails.Text;

            ViewModelLocator.SupplierViewModel.AddSupplier(sname, sdetails);
            ViewModelLocator.SupplierViewModel.CreateSupplierList();

            var oswindow = new SuppliersPage();
            oswindow.Show();
            this.Close();
        }

        private void btnCancelAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            var oswindow = new SuppliersPage();
            oswindow.Show();
            this.Close();
        }
    }
}
