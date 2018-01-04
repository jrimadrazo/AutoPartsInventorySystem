using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTables
{
    class SUPPLIER
    {
        private int supplierID;
        private string supplierName;
        private string supplierDetails;

        public int SupplierID {
            get { return supplierID; }
            set { supplierID = value; }
        }
        public string SupplierName {
            get { return supplierName; }
            set { supplierName = value; }
        }
        public string SupplierDetails {
            get { return supplierDetails; }
            set { supplierDetails = value; }
        }

        public SUPPLIER()
        {}

        public SUPPLIER(int sid, string sname, string sdetails)
        {
            SupplierID = sid;
            SupplierName = sname;
            SupplierDetails = sdetails;
        }
    }
}
