using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsInventorySystem
{
    public class SUPPLIER
    {
        private int _supplierID;
        private string _supplierName;
        private string _supplierDetails;

        public int SupplierID
        {
            get { return _supplierID; }
            set { _supplierID = value; }
        }

        public string SupplierName
        {
            get { return _supplierName; }
            set { _supplierName = value; }
        }

        public string SupplierDetails
        {
            get { return _supplierDetails; }
            set { _supplierDetails = value; }
        }

        public SUPPLIER()
        {}

        public SUPPLIER(int supplierID, string supplierName, string supplierDetails)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            SupplierDetails = supplierDetails;
        }
    }
}
