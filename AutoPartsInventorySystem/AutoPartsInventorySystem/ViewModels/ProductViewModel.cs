using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoPartsInventorySystem
{
    public class ProductViewModel
    {
        public ObservableCollection<PRODUCT> ProductList { get; set; }
        public PRODUCT SelectedProduct { get; set; }

        public ProductViewModel()
        {
            ProductList = new ObservableCollection<PRODUCT>();
            CreateProductList();
        }

        public void CreateProductList()
        {
            ProductList.Clear();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            SqlDataAdapter autoNode1 = new SqlDataAdapter("SELECT * From [PRODUCT]", con);
            DataTable dt = new DataTable();
            autoNode1.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PRODUCT newProduct = new PRODUCT();

                newProduct.ProductID = Convert.ToInt16(dt.Rows[i]["Product_ID"]);
                newProduct.ProductName = dt.Rows[i]["Product_Name"].ToString();
                newProduct.ProductType = dt.Rows[i]["Product_Type"].ToString();
                newProduct.ProductQuantity = Convert.ToInt16(dt.Rows[i]["Quantity"]);
                newProduct.ProductColor = dt.Rows[i]["Color"].ToString();
                newProduct.ProductBuyingPrice = Convert.ToInt16(dt.Rows[i]["Buying_Price"]);
                newProduct.ProductSellingPrice = Convert.ToInt16(dt.Rows[i]["Selling_Price"]);

                ProductList.Add(newProduct);
            }
        }

        public void AddProduct(string pname, string ptype, int pquantity, string pcolor, int pbuyp, int psellp)
        {
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
        }
    }
}
