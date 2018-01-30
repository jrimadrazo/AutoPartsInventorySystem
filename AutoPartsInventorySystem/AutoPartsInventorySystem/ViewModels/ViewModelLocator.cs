using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsInventorySystem
{
    public static class ViewModelLocator
    {
        private static OrderViewModel _orderViewModel;
        private static ProductViewModel _productViewModel;
        private static SupplierViewModel _supplierViewModel;

        public static OrderViewModel OrderViewModel
        {
            get
            {
                if (_orderViewModel == null)
                {
                    _orderViewModel = new OrderViewModel();
                }

                return _orderViewModel;
            }
        }

        public static ProductViewModel ProductViewModel
        {
            get
            {
                if (_productViewModel == null)
                {
                    _productViewModel = new ProductViewModel();
                }

                return _productViewModel;
            }
        }

        public static SupplierViewModel SupplierViewModel
        {
            get
            {
                if (_supplierViewModel == null)
                {
                    _supplierViewModel = new SupplierViewModel();
                }

                return _supplierViewModel;
            }
        }
    }
}
