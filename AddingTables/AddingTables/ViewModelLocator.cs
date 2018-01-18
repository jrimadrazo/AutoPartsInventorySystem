using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTables
{
    public static class ViewModelLocator
    {
        static MainViewModel _mainViewModel;

        public static MainViewModel MainViewModel
        {
            get
            {
                if (_mainViewModel == null)
                    _mainViewModel = new MainViewModel();

                return _mainViewModel;
            }
        }
    }
}
