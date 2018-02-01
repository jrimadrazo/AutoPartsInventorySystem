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
    /// Interaction logic for EditSupplierWindow.xaml
    /// </summary>
    public partial class EditSupplierWindow : Window
    {
        public EditSupplierWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModelLocator.SupplierViewModel.SelectedSupplier;
        }

        private void btnEditSupplier_Click(object sender, RoutedEventArgs e)
        {
            var sid = ViewModelLocator.SupplierViewModel.SelectedSupplier.SupplierID;
            var sname = tbxEditSupplierName.Text;
            var sdetails = tbxEditSupplierDetails.Text;

            ViewModelLocator.SupplierViewModel.EditSupplier(sid, sname, sdetails);
            ViewModelLocator.SupplierViewModel.CreateSupplierList();

            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void btnCancelEditSupplier_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
