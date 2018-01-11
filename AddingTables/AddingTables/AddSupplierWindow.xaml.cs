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
    /// Interaction logic for AddSupplierWindow.xaml
    /// </summary>
    public partial class AddSupplierWindow : Window
    {
        public AddSupplierWindow()
        {
            InitializeComponent();
        }

        private void btnAddSuppler_Click(object sender, RoutedEventArgs e)
        {
            var sname = tbxSupplierName.Text;
            var sdetails = tbxSupplierDetails.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            SqlCommand command1 = new SqlCommand();
            command1 = new SqlCommand("INSERT INTO [SUPPLIER] (Supplier_Name, Supplier_Details)" + "VALUES (@Supplier_Name, @Supplier_Details)", con);
            command1.Parameters.AddWithValue("@Supplier_Name", sname);
            command1.Parameters.AddWithValue("@Supplier_Details", sdetails);
            command1.ExecuteNonQuery();

            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void btnCancelAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
    }
}
