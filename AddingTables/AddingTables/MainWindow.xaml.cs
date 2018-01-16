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
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            //con.Open();
            ////SqlDataAdapter autoNode1 = new SqlDataAdapter();
            //SqlCommand command1 = new SqlCommand();
            //command1 = new SqlCommand("INSERT INTO [SUPPLIER] (Supplier_Name, Supplier_Details)" + "VALUES (@Supplier_Name, @Supplier_Details)", con);
            //command1.Parameters.AddWithValue("@Supplier_Name", );
            //command1.Parameters.AddWithValue("@Supplier_Details", );
            //command1.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //autoNode1.Fill(dt);

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    object obproductname = dt.Rows[i]["Product_Name"];
            //    MessageBox.Show(obproductname.ToString());
            //}

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            AddingTables.AutoPartsInventoryDataSet autoPartsInventoryDataSet = ((AddingTables.AutoPartsInventoryDataSet)(this.FindResource("autoPartsInventoryDataSet")));
            // Load data into the table PRODUCT. You can modify this code as needed.
            AddingTables.AutoPartsInventoryDataSetTableAdapters.PRODUCTTableAdapter autoPartsInventoryDataSetPRODUCTTableAdapter = new AddingTables.AutoPartsInventoryDataSetTableAdapters.PRODUCTTableAdapter();
            autoPartsInventoryDataSetPRODUCTTableAdapter.Fill(autoPartsInventoryDataSet.PRODUCT);
            System.Windows.Data.CollectionViewSource pRODUCTViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("pRODUCTViewSource")));
            pRODUCTViewSource.View.MoveCurrentToFirst();
            // Load data into the table SUPPLIER. You can modify this code as needed.
            AddingTables.AutoPartsInventoryDataSetTableAdapters.SUPPLIERTableAdapter autoPartsInventoryDataSetSUPPLIERTableAdapter = new AddingTables.AutoPartsInventoryDataSetTableAdapters.SUPPLIERTableAdapter();
            autoPartsInventoryDataSetSUPPLIERTableAdapter.Fill(autoPartsInventoryDataSet.SUPPLIER);
            System.Windows.Data.CollectionViewSource sUPPLIERViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("sUPPLIERViewSource")));
            sUPPLIERViewSource.View.MoveCurrentToFirst();
            // Load data into the table ORDER. You can modify this code as needed.
            AddingTables.AutoPartsInventoryDataSetTableAdapters.ORDERTableAdapter autoPartsInventoryDataSetORDERTableAdapter = new AddingTables.AutoPartsInventoryDataSetTableAdapters.ORDERTableAdapter();
            autoPartsInventoryDataSetORDERTableAdapter.Fill(autoPartsInventoryDataSet.ORDER);
            System.Windows.Data.CollectionViewSource oRDERViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("oRDERViewSource")));
            oRDERViewSource.View.MoveCurrentToFirst();
        }

        private void pRODUCTDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddingTables.AutoPartsInventoryDataSet autoPartsInventoryDataSet = ((AddingTables.AutoPartsInventoryDataSet)(this.FindResource("autoPartsInventoryDataSet")));

            productID.Text = autoPartsInventoryDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Product_ID.ToString();
            productName.Text = autoPartsInventoryDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Product_Name.ToString();
            productType.Text = autoPartsInventoryDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Product_Type.ToString();
            qUantity.Text = autoPartsInventoryDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Quantity.ToString();
            cOlor.Text = autoPartsInventoryDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Color.ToString();
            buyingPrice.Text = autoPartsInventoryDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Buying_Price.ToString("##.00");
            sellingPrice.Text = autoPartsInventoryDataSet.PRODUCT[pRODUCTDataGrid.SelectedIndex].Selling_Price.ToString("##.00");
        }

        private void sUPPLIERDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddingTables.AutoPartsInventoryDataSet autoPartsInventoryDataSet = ((AddingTables.AutoPartsInventoryDataSet)(this.FindResource("autoPartsInventoryDataSet")));

            supplierID.Text = autoPartsInventoryDataSet.SUPPLIER[sUPPLIERDataGrid.SelectedIndex].Supplier_ID.ToString();
            supplierName.Text = autoPartsInventoryDataSet.SUPPLIER[sUPPLIERDataGrid.SelectedIndex].Supplier_Name.ToString();
            dEscription.Text = autoPartsInventoryDataSet.SUPPLIER[sUPPLIERDataGrid.SelectedIndex].Supplier_Details.ToString();
        }

        private void oRDERDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddingTables.AutoPartsInventoryDataSet autoPartsInventoryDataSet = ((AddingTables.AutoPartsInventoryDataSet)(this.FindResource("autoPartsInventoryDataSet")));

            orderID.Text = autoPartsInventoryDataSet.ORDER[oRDERDataGrid.SelectedIndex].Order_ID.ToString();
            producTID.Text = autoPartsInventoryDataSet.ORDER[oRDERDataGrid.SelectedIndex].Product_ID.ToString();
            supplieRID.Text = autoPartsInventoryDataSet.ORDER[oRDERDataGrid.SelectedIndex].Supplier_ID.ToString();
            dAte.Text = autoPartsInventoryDataSet.ORDER[oRDERDataGrid.SelectedIndex].Date.ToString("MMMM dd, yyyy");
            qUAntity.Text = autoPartsInventoryDataSet.ORDER[oRDERDataGrid.SelectedIndex].Quantity_Ordered.ToString();
        }

        private void btnAddSupplierWindow_Click(object sender, RoutedEventArgs e)
        {
            AddSupplierWindow win2 = new AddSupplierWindow();
            win2.Show();
            this.Close();
        }

        private void btnAddOrderWindow_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow win3 = new AddOrderWindow();
            win3.Show();
            this.Close();
        }

        private void btnAddProductWindow_Click(object sender, RoutedEventArgs e)
        {
            AddingTables.Window1 win4 = new AddingTables.Window1();
            win4.Show();
            this.Close();
        }

        private void btnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            EditProduct win4 = new EditProduct();
            win4.Show();
            this.Close();
        }
    }
}
