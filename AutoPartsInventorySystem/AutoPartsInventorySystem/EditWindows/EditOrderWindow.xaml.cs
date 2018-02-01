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
    /// Interaction logic for EditOrderWindow.xaml
    /// </summary>
    public partial class EditOrderWindow : Window
    {
        public EditOrderWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModelLocator.OrderViewModel.SelectedOrder;
        }

        private void btnEditOrder_Click(object sender, RoutedEventArgs e)
        {
            var oid = ViewModelLocator.OrderViewModel.SelectedOrder.OrderID;
            int osupplierid = Convert.ToInt16(tbxEditSupplierID.Text);
            int oproductid = Convert.ToInt16(tbxEditProductID.Text);
            DateTime odate = Convert.ToDateTime(tbxEditDateOrdered.SelectedDate);
            int oquantity = Convert.ToInt16(tbxEditQuantityOrdered.Text);

            ViewModelLocator.OrderViewModel.EditOrder(oid, osupplierid, oproductid, odate, oquantity);
            ViewModelLocator.OrderViewModel.CreateOrderList();

            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void btnCancelEditOrder_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
