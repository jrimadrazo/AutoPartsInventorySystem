using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
//using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Threading;
using System.IO.Ports;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace AddingTables
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter autoNode1 = new SqlDataAdapter("SELECT Product_Name FROM [PRODUCT]", con);
            DataTable dt = new DataTable();
            autoNode1.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object obproductname = dt.Rows[i]["Product_Name"];
                MessageBox.Show(obproductname.ToString());
            }

            //SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            //con1.Open();
            //SqlDataAdapter adapter1 = new SqlDataAdapter();
            //SqlCommand command1 = new SqlCommand();
            //command1 = new SqlCommand("INSERT INTO [PRODUCT] (Product_ID, Product_Name, Product_Type, Quantity, Color, Buying_Price, Selling_Price)" + "VALUES (@Product_ID, @Product_Name, @Product_Type, @Quantity, @Color, @Buying_Price, @Selling_Price)", con1);
            //command1.Parameters.AddWithValue("@Product_ID", 5);
            //command1.Parameters.AddWithValue("@Product_Name", "Brake Pads");
            //command1.Parameters.AddWithValue("@Product_Type", "Exterior");
            //command1.Parameters.AddWithValue("@Quantity", 5);
            //command1.Parameters.AddWithValue("@Color", "Black");
            //command1.Parameters.AddWithValue("@Buying_Price", 125.00);
            //command1.Parameters.AddWithValue("@Selling_Price", 150.00);
            //command1.ExecuteNonQuery();
        }
    }
}
