﻿#pragma checksum "..\..\EditProduct.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2692C2F37CC0F380B0A99D1A55D8C0FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AddingTables;
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


namespace AddingTables {
    
    
    /// <summary>
    /// EditProduct
    /// </summary>
    public partial class EditProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AddingTables.EditProduct EditProduct;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxEditProductName;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxEditProductType;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxEditQuantity;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxEditColor;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxEditBuyPrice;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxEditSellPrice;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditProduct;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelEditProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/AddingTables;component/editproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditProduct.xaml"
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
            this.EditProduct = ((AddingTables.EditProduct)(target));
            return;
            case 2:
            this.tbxEditProductName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbxEditProductType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbxEditQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbxEditColor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbxEditBuyPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbxEditSellPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnEditProduct = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\EditProduct.xaml"
            this.btnEditProduct.Click += new System.Windows.RoutedEventHandler(this.btnEditProduct_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnCancelEditProduct = ((System.Windows.Controls.Button)(target));
            
            #line 139 "..\..\EditProduct.xaml"
            this.btnCancelEditProduct.Click += new System.Windows.RoutedEventHandler(this.btnCancelEditProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

