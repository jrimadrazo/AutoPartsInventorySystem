﻿#pragma checksum "..\..\..\AddWindows\AddProductWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1D587256884C4D070BF90C166F26134B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoPartsInventorySystem;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AutoPartsInventorySystem {
    
    
    /// <summary>
    /// AddProductWindow
    /// </summary>
    public partial class AddProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\AddWindows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AutoPartsInventorySystem.AddProductWindow wndAddProduct;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\AddWindows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxProductName;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\AddWindows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxProductType;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\AddWindows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxQuantity;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\AddWindows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxColor;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\AddWindows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxBuyingPrice;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\AddWindows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxSellingPrice;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\AddWindows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddProduct;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\AddWindows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelAddProduct;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AutoPartsInventorySystem;component/addwindows/addproductwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddWindows\AddProductWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.wndAddProduct = ((AutoPartsInventorySystem.AddProductWindow)(target));
            return;
            case 2:
            this.tbxProductName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbxProductType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbxQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbxColor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbxBuyingPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbxSellingPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\..\AddWindows\AddProductWindow.xaml"
            this.btnAddProduct.Click += new System.Windows.RoutedEventHandler(this.btnAddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnCancelAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\AddWindows\AddProductWindow.xaml"
            this.btnCancelAddProduct.Click += new System.Windows.RoutedEventHandler(this.btnCancelAddProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

