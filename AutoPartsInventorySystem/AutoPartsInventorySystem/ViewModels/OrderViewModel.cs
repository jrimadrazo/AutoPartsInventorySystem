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

            SqlConnection con = Methods.AccessDatabase();
            SqlDataAdapter autoNode = new SqlDataAdapter("SELECT * From [ORDER]", con);
            DataTable dt = new DataTable();
            autoNode.Fill(dt);

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
            SqlConnection con = Methods.AccessDatabase();
            SqlCommand command = new SqlCommand("INSERT INTO [ORDER] (Supplier_ID, Product_ID, Date, Quantity_Ordered)" + "VALUES (@Supplier_ID, @Product_ID, @Date, @Quantity_Ordered)", con);
            command.Parameters.AddWithValue("@Supplier_ID", osupplierid);
            command.Parameters.AddWithValue("@Product_ID", oproductid);
            command.Parameters.AddWithValue("@Date", odate);
            command.Parameters.AddWithValue("@Quantity_Ordered", oquantity);
            command.ExecuteNonQuery();
        }

        public void EditOrder(int oid, int osupplierid, int oproductid, DateTime odate, int oquantity)
        {
            if (SelectedOrder != null)
            {
                SqlConnection con = Methods.AccessDatabase();
                SqlCommand command = new SqlCommand("UPDATE [ORDER] SET Supplier_ID = @Supplier_ID, Product_ID = @Product_ID, Date = @Date, Quantity_Ordered = @Quantity_Ordered WHERE Order_ID = " + oid, con);
                command.Parameters.AddWithValue("@Supplier_ID", osupplierid);
                command.Parameters.AddWithValue("@Product_ID", oproductid);
                command.Parameters.AddWithValue("@Date", odate);
                command.Parameters.AddWithValue("@Quantity_Ordered", oquantity);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteOrder(int oid)
        {
            if (SelectedOrder != null)
            {
                SqlConnection con = Methods.AccessDatabase();
                SqlCommand command = new SqlCommand("DELETE FROM [ORDER] WHERE Order_ID = " + oid, con);
                command.ExecuteNonQuery();
            }
        }
    }
}
