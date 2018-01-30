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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            SqlDataAdapter autoNode1 = new SqlDataAdapter("SELECT * From [SUPPLIER]", con);
            DataTable dt = new DataTable();
            autoNode1.Fill(dt);

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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            SqlCommand command1 = new SqlCommand();
            command1 = new SqlCommand("INSERT INTO [SUPPLIER] (Supplier_Name, Supplier_Details)" + "VALUES (@Supplier_Name, @Supplier_Details)", con);
            command1.Parameters.AddWithValue("@Supplier_Name", sname);
            command1.Parameters.AddWithValue("@Supplier_Details", sdetails);
            command1.ExecuteNonQuery();
        }
    }
}
