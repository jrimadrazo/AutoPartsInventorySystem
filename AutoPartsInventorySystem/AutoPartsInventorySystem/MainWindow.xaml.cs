﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoPartsInventorySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.tbProduct.DataContext = ViewModelLocator.ProductViewModel;
            this.tbSupplier.DataContext = ViewModelLocator.SupplierViewModel;
            this.tbOrder.DataContext = ViewModelLocator.OrderViewModel;
            //this.gdProductInfo.DataContext = ViewModelLocator.ProductViewModel.SelectedProduct;
        }

        private void btnAddProductWindow_Click(object sender, RoutedEventArgs e)
        {
            var apwindow = new AddProductWindow();
            apwindow.Show();
            this.Close();
        }

        private void btnEditProductWindow_Click(object sender, RoutedEventArgs e)
        {
            var epwindow = new EditProductWindow();
            epwindow.Show();
            this.Close();
        }

        private void btnAddSupplierWindow_Click(object sender, RoutedEventArgs e)
        {
            var aswindow = new AddSupplierWindow();
            aswindow.Show();
            this.Close();
        }

        private void btnEditSupplierWindow_Click(object sender, RoutedEventArgs e)
        {
            var eswindow = new EditSupplierWindow();
            eswindow.Show();
            this.Close();
        }

        private void btnAddOrderWindow_Click(object sender, RoutedEventArgs e)
        {
            var aowindow = new AddOrderWindow();
            aowindow.Show();
            this.Close();
        }

        private void btnEditOrderWindow_Click(object sender, RoutedEventArgs e)
        {
            var eowindow = new EditOrderWindow();
            eowindow.Show();
            this.Close();
        }
    }
}
