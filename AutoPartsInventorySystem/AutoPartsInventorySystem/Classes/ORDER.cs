using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsInventorySystem
{
    public class ORDER
    {
        private int _orderID;
        private int _supplierID;
        private int _productID;
        private DateTime _dateOrdered;
        private int _quantityOrdered;

        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }

        public int SupplierID
        {
            get { return _supplierID; }
            set { _supplierID = value; }
        }

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public DateTime DateOrdered
        {
            get { return _dateOrdered; }
            set { _dateOrdered = value; }
        }

        public int QuantityOrdered
        {
            get { return _quantityOrdered; }
            set { _quantityOrdered = value; }
        }

        public ORDER()
        {}

        public ORDER(int oid, int sid, int pid, DateTime dateOrdered, int quantityOrdered)
        {
            OrderID = oid;
            SupplierID = sid;
            ProductID = pid;
            DateOrdered = dateOrdered;
            QuantityOrdered = quantityOrdered;
        }
    }
}
