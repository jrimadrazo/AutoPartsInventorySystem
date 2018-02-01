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
    public class SupplierViewModel
    {
        public ObservableCollection<SUPPLIER> SupplierList { get; set; }
        public SUPPLIER SelectedSupplier { get; set; }

        public SupplierViewModel()
        {
            SupplierList = new ObservableCollection<SUPPLIER>();
            CreateSupplierList();
        }

        public void CreateSupplierList()
        {
            SupplierList.Clear();

            SqlConnection con = Methods.AccessDatabase();
            SqlDataAdapter autoNode = new SqlDataAdapter("SELECT * From [SUPPLIER]", con);
            DataTable dt = new DataTable();
            autoNode.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SUPPLIER newSupplier = new SUPPLIER();

                newSupplier.SupplierID = Convert.ToInt16(dt.Rows[i]["Supplier_ID"]);
                newSupplier.SupplierName = dt.Rows[i]["Supplier_Name"].ToString();
                newSupplier.SupplierDetails = dt.Rows[i]["Supplier_Details"].ToString();

                SupplierList.Add(newSupplier);
            }
        }

        public void AddSupplier(string sname, string sdetails)
        {
            SqlConnection con = Methods.AccessDatabase();
            SqlCommand command = new SqlCommand("INSERT INTO [SUPPLIER] (Supplier_Name, Supplier_Details)" + "VALUES (@Supplier_Name, @Supplier_Details)", con);
            command.Parameters.AddWithValue("@Supplier_Name", sname);
            command.Parameters.AddWithValue("@Supplier_Details", sdetails);
            command.ExecuteNonQuery();
        }

        public void EditSupplier(int sid, string sname, string sdetails)
        {
            if (SelectedSupplier != null)
            {
                SqlConnection con = Methods.AccessDatabase();
                SqlCommand command = new SqlCommand("UPDATE [SUPPLIER] SET Supplier_Name = @Supplier_Name, Supplier_Details = @Supplier_Details WHERE Supplier_ID = " + sid, con);
                command.Parameters.AddWithValue("@Supplier_Name", sname);
                command.Parameters.AddWithValue("@Supplier_Details", sdetails);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSupplier(int sid)
        {
            if (SelectedSupplier != null)
            {
                SqlConnection con = Methods.AccessDatabase();
                SqlCommand command = new SqlCommand("DELETE FROM [SUPPLIER] WHERE Supplier_ID = " + sid, con);
                command.ExecuteNonQuery();
            }
        }
    }
}
