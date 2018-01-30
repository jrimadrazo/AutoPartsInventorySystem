using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsInventorySystem
{
    public class PRODUCT
    {
        private int _productID;
        private string _productName;
        private string _productType;
        private int _productQuantity;
        private string _productColor;
        private int _productBuy;
        private int _productSell;

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public string ProductType
        {
            get { return _productType; }
            set { _productType = value; }
        }

        public int ProductQuantity
        {
            get { return _productQuantity; }
            set { _productQuantity = value; }
        }

        public string ProductColor
        {
            get { return _productColor; }
            set { _productColor = value; }
        }

        public int ProductBuyingPrice
        {
            get { return _productBuy; }
            set { _productBuy = value; }
        }

        public int ProductSellingPrice
        {
            get { return _productSell; }
            set { _productSell = value; }
        }

        public PRODUCT()
        {}

        public PRODUCT(int productID, string productName, string productType, int productQuantity, string productColor, int productBuyingPrice, int productSellingPrice)
        {
            ProductID = productID;
            ProductName = productName;
            ProductType = productType;
            ProductQuantity = productQuantity;
            ProductColor = productColor;
            ProductBuyingPrice = productBuyingPrice;
            ProductSellingPrice = productSellingPrice;
        }
    }
}
