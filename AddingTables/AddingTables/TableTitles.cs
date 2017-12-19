using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTables
{
    class TableTitles
    {
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductColor { get; set; }
        public int ProductBuy { get; set; }
        public int ProductSell { get; set; }

        public Product()
        {}
        public Product(int id, string name, string type, int quantity, string color, int buy, int sell)
        {
            ProductID = id;
            ProductName = name;
            ProductType = type;
            ProductQuantity = quantity;
            ProductColor = color;
            ProductBuy = buy;
            ProductSell = sell;
        }
    }

    public class Supplier
    { }

   public class Orders
    { }
}
