using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoPartsInventorySystem
{
    public static class Methods
    {
        public static SqlConnection AccessDatabase()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrimadrazo\Documents\Visual Studio 2015\Projects\AddingTables\AddingTables\AutoPartsInventory.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            return con;
        }
    }
}
