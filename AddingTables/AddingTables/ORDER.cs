using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTables
{
    class ORDER
    {
        private int orderID;
        private int supplierID;
        private int productID;
        private DateTime dateOrdered;
        private int quantityOrdered;

        public int OrderID {
            get { return orderID; }
            set { orderID = value; }
        }
        public int SupplierID {
            get { return supplierID; }
            set { supplierID = value; }
        }
        public int ProductID {
            get { return productID; }
            set { productID = value; }
        }
        public DateTime DateOrdered {
            get { return dateOrdered; }
            set { dateOrdered = value; }
        }
        public int QuantityOrdered {
            get { return quantityOrdered; }
            set { quantityOrdered = value; }
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
