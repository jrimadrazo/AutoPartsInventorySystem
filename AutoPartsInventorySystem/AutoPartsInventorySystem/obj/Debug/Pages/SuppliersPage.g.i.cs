﻿#pragma checksum "..\..\..\Pages\SuppliersPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB5CDEEB54490BA0EF99D08717CEBA52"
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
    /// SuppliersPage
    /// </summary>
    public partial class SuppliersPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Pages\SuppliersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturnSupplierWindow;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Pages\SuppliersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbSupplierData;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Pages\SuppliersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSupplierWindow;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Pages\SuppliersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteSupplierWindow;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Pages\SuppliersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blkSupplierID;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\Pages\SuppliersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blkSupplierName;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\Pages\SuppliersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blkSupplierDetails;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\Pages\SuppliersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbProductsSupplied;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\..\Pages\SuppliersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditSupplierWindow;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoPartsInventorySystem;component/pages/supplierspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\SuppliersPage.xaml"
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
            this.btnReturnSupplierWindow = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Pages\SuppliersPage.xaml"
            this.btnReturnSupplierWindow.Click += new System.Windows.RoutedEventHandler(this.btnReturnSupplierWindow_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbSupplierData = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.btnAddSupplierWindow = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Pages\SuppliersPage.xaml"
            this.btnAddSupplierWindow.Click += new System.Windows.RoutedEventHandler(this.btnAddSupplierWindow_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDeleteSupplierWindow = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\..\Pages\SuppliersPage.xaml"
            this.btnDeleteSupplierWindow.Click += new System.Windows.RoutedEventHandler(this.btnDeleteSupplierWindow_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.blkSupplierID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.blkSupplierName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.blkSupplierDetails = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.lbProductsSupplied = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.btnEditSupplierWindow = ((System.Windows.Controls.Button)(target));
            
            #line 227 "..\..\..\Pages\SuppliersPage.xaml"
            this.btnEditSupplierWindow.Click += new System.Windows.RoutedEventHandler(this.btnEditSupplierWindow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
