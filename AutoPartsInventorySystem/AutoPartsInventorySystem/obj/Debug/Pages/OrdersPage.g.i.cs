﻿#pragma checksum "..\..\..\Pages\OrdersPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3307697E9E7589BAABA8A97A6CF0B1FF"
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
    /// OrdersPage
    /// </summary>
    public partial class OrdersPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Pages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturnOrderWindow;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Pages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbOrderData;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\Pages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blkOrderID;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Pages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blkOProductID;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\Pages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blkOSupplierID;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Pages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blkOrderDat;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\Pages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blkOrderQuantity;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\Pages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddOrderWindow;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\Pages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditOrderWindow;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\Pages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteOrderWindow;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoPartsInventorySystem;component/pages/orderspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\OrdersPage.xaml"
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
            this.btnReturnOrderWindow = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Pages\OrdersPage.xaml"
            this.btnReturnOrderWindow.Click += new System.Windows.RoutedEventHandler(this.btnReturnOrderWindow_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbOrderData = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.blkOrderID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.blkOProductID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.blkOSupplierID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.blkOrderDat = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.blkOrderQuantity = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.btnAddOrderWindow = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\..\Pages\OrdersPage.xaml"
            this.btnAddOrderWindow.Click += new System.Windows.RoutedEventHandler(this.btnAddOrderWindow_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnEditOrderWindow = ((System.Windows.Controls.Button)(target));
            
            #line 195 "..\..\..\Pages\OrdersPage.xaml"
            this.btnEditOrderWindow.Click += new System.Windows.RoutedEventHandler(this.btnEditOrderWindow_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnDeleteOrderWindow = ((System.Windows.Controls.Button)(target));
            
            #line 220 "..\..\..\Pages\OrdersPage.xaml"
            this.btnDeleteOrderWindow.Click += new System.Windows.RoutedEventHandler(this.btnDeleteOrderWindow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

