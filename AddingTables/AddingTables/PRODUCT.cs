using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTables
{
    class PRODUCT
    {
        private int productID;
        private string productName;
        private string productType;
        private int productQuantity;
        private string productColor;
        private int productBuy;
        private int productSell;

        public int ProductID {
            get { return productID; }
            set { productID = value; }
        }
        public string ProductName {
            get { return productName; }
            set { productName = value; }
        }
        public string ProductType {
            get { return productType; }
            set { productType = value; }
        }
        public int ProductQuantity {
            get { return productQuantity; }
            set { productQuantity = value; }
        }
        public string ProductColor {
            get { return productColor; }
            set { productColor = value; }
        }
        public int ProductBuy {
            get { return productBuy; }
            set { productBuy = value; }
        }
        public int ProductSell {
            get { return productSell; }
            set { productSell = value; }
        }

        public PRODUCT()
        { }
        public PRODUCT(int pid, string pname, string ptype, int pquantity, string pcolor, int pbuy, int psell)
        {
            ProductID = pid;
            ProductName = pname;
            ProductType = ptype;
            ProductQuantity = pquantity;
            ProductColor = pcolor;
            ProductBuy = pbuy;
            ProductSell = psell;
        }

        public float getTotalCost()
        {
            return ProductBuy * ProductQuantity;
        }

        public float getEstimatedSales()
        {
            return ProductSell * ProductQuantity;
        }
    }
}
