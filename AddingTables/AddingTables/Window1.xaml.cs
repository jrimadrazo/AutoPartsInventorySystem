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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            var pname = tbxProductName.Text;
            var ptype = tbxProductType.Text;
            var pquantity = tbxQuantity.Text;
            var pcolor = tbxColor.Text;
            var pbuyp = tbxBuyPrice.Text;
            var psellp = tbxSellPrice.Text;

            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            con2.Open();
            SqlCommand command3 = new SqlCommand();
            command3 = new SqlCommand("INSERT INTO [PRODUCT] (Product_Name, Product_Type, Quantity, Color, Buying_Price, Selling_Price)" + "VALUES (@Product_Name, @Product_Type, @Quantity, @Color, @Buying_Price, @Selling_Price)", con2);
            command3.Parameters.AddWithValue("@Product_Name", pname);
            command3.Parameters.AddWithValue("@Product_Type", ptype);
            command3.Parameters.AddWithValue("@Quantity", pquantity);
            command3.Parameters.AddWithValue("@Color", pcolor);
            command3.Parameters.AddWithValue("@Buying_Price", pbuyp);
            command3.Parameters.AddWithValue("@Selling_Price", psellp);
            command3.ExecuteNonQuery();

            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void btnCancelAddProduct_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
    }
}
