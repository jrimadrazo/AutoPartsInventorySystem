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
    public class OrderViewModel
    {
        public ObservableCollection<ORDER> OrderList { get; set; }
        public ORDER SelectedOrder { get; set; }

        public OrderViewModel()
        {
            OrderList = new ObservableCollection<ORDER>();
            CreateOrderList();
        }

        public void CreateOrderList()
        {
            OrderList.Clear();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            SqlDataAdapter autoNode1 = new SqlDataAdapter("SELECT * From [ORDER]", con);
            DataTable dt = new DataTable();
            autoNode1.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ORDER newOrder = new ORDER();

                newOrder.OrderID = Convert.ToInt16(dt.Rows[i]["Order_ID"]);
                newOrder.SupplierID = Convert.ToInt16(dt.Rows[i]["Supplier_ID"]);
                newOrder.ProductID = Convert.ToInt16(dt.Rows[i]["Product_ID"]);
                newOrder.DateOrdered = Convert.ToDateTime(dt.Rows[i]["Date"]);
                newOrder.QuantityOrdered = Convert.ToInt16(dt.Rows[i]["Quantity_Ordered"]);

                OrderList.Add(newOrder);
            }
        }

        public void AddOrder(int osupplierid, int oproductid, DateTime odate, int oquantity)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            con1.Open();
            SqlCommand command2 = new SqlCommand();
            command2 = new SqlCommand("INSERT INTO [ORDER] (Supplier_ID, Product_ID, Date, Quantity_Ordered)" + "VALUES (@Supplier_ID, @Product_ID, @Date, @Quantity_Ordered)", con1);
            command2.Parameters.AddWithValue("@Supplier_ID", osupplierid);
            command2.Parameters.AddWithValue("@Product_ID", oproductid);
            command2.Parameters.AddWithValue("@Date", odate);
            command2.Parameters.AddWithValue("@Quantity_Ordered", oquantity);
            command2.ExecuteNonQuery();
        }
    }
}
