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
    /// Interaction logic for AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        public AddOrderWindow()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            int osupplierid = Convert.ToInt16(tbxSupplierID.Text);
            int oproductid = Convert.ToInt16(tbxProductID.Text);
            DateTime odate = Convert.ToDateTime(tbxDateOrdered.SelectedDate);
            int oquantity = Convert.ToInt16(tbxQuantityOrdered.Text);

            ViewModelLocator.OrderViewModel.AddOrder(osupplierid, oproductid, odate, oquantity);
            ViewModelLocator.OrderViewModel.CreateOrderList();

            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void btnCancelAddOrder_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
