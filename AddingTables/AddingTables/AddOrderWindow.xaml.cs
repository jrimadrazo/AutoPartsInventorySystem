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
using System.Data;
using System.Data.SqlClient;

namespace AddingTables
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
            var osupplierid = tbxSupplierID.Text;
            var oproductid = tbxProductID.Text;
            var odate = tbxDate.SelectedDate;
            var oquantity = tbxQuantityOrdered.Text;

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            con1.Open();
            SqlCommand command2 = new SqlCommand();
            command2 = new SqlCommand("INSERT INTO [ORDER] (Supplier_ID, Product_ID, Date, Quantity_Ordered)" + "VALUES (@Supplier_ID, @Product_ID, @Date, @Quantity_Ordered)", con1);
            command2.Parameters.AddWithValue("@Supplier_ID", osupplierid);
            command2.Parameters.AddWithValue("@Product_ID", oproductid);
            command2.Parameters.AddWithValue("@Date", odate);
            command2.Parameters.AddWithValue("@Quantity_Ordered", oquantity);
            command2.ExecuteNonQuery();

            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void btnCancelAddOrder_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
    }
}
