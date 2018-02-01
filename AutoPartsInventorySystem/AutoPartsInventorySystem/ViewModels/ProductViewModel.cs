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

            SqlConnection con = Methods.AccessDatabase();
            SqlDataAdapter autoNode = new SqlDataAdapter("SELECT * From [PRODUCT]", con);
            DataTable dt = new DataTable();
            autoNode.Fill(dt);

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
            SqlConnection con = Methods.AccessDatabase();
            SqlCommand command = new SqlCommand("INSERT INTO [PRODUCT] (Product_Name, Product_Type, Quantity, Color, Buying_Price, Selling_Price)" + "VALUES (@Product_Name, @Product_Type, @Quantity, @Color, @Buying_Price, @Selling_Price)", con);
            command.Parameters.AddWithValue("@Product_Name", pname);
            command.Parameters.AddWithValue("@Product_Type", ptype);
            command.Parameters.AddWithValue("@Quantity", pquantity);
            command.Parameters.AddWithValue("@Color", pcolor);
            command.Parameters.AddWithValue("@Buying_Price", pbuyp);
            command.Parameters.AddWithValue("@Selling_Price", psellp);
            command.ExecuteNonQuery();
        }

        public void EditProduct(int pid, string pname, string ptype, int pquantity, string pcolor, int pbuyp, int psellp)
        {
            if (SelectedProduct != null)
            {
                SqlConnection con = Methods.AccessDatabase();
                SqlCommand command = new SqlCommand("UPDATE [PRODUCT] SET Product_Name = @Product_Name, Product_Type = @Product_Type, Quantity = @Quantity, Color = @Color, Buying_Price = @Buying_Price, Selling_Price = @Selling_Price WHERE Product_ID = " + pid, con);
                command.Parameters.AddWithValue("@Product_Name", pname);
                command.Parameters.AddWithValue("@Product_Type", ptype);
                command.Parameters.AddWithValue("@Quantity", pquantity);
                command.Parameters.AddWithValue("@Color", pcolor);
                command.Parameters.AddWithValue("@Buying_Price", pbuyp);
                command.Parameters.AddWithValue("@Selling_Price", psellp);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int pid)
        {
            if (SelectedProduct != null)
            {
                SqlConnection con = Methods.AccessDatabase();
                SqlCommand command = new SqlCommand("DELETE FROM [PRODUCT] WHERE Product_ID = " + pid, con);
                command.ExecuteNonQuery();
            }
        }
    }
}
