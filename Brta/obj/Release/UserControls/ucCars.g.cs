﻿#pragma checksum "..\..\..\UserControls\ucCars.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "50C8EB60760606188A36F0BA32A4BC9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8009
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Primitives;
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


namespace Brta.UserControls {
    
    
    /// <summary>
    /// ucCars
    /// </summary>
    public partial class ucCars : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\UserControls\ucCars.xaml"
        internal System.Windows.Controls.ComboBox cboGroup;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UserControls\ucCars.xaml"
        internal System.Windows.Controls.ComboBox cboModel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UserControls\ucCars.xaml"
        internal System.Windows.Controls.TextBox txtRegNo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UserControls\ucCars.xaml"
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UserControls\ucCars.xaml"
        internal Microsoft.Windows.Controls.DataGrid dtgCars;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\UserControls\ucCars.xaml"
        internal System.Windows.Controls.Button btnAddCar;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\UserControls\ucCars.xaml"
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\UserControls\ucCars.xaml"
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Brta;component/usercontrols/uccars.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\ucCars.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cboGroup = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\UserControls\ucCars.xaml"
            this.cboGroup.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboGroup_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboModel = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\..\UserControls\ucCars.xaml"
            this.cboModel.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboModel_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtRegNo = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\UserControls\ucCars.xaml"
            this.txtRegNo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtRegNo_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\UserControls\ucCars.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.btnClear_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtgCars = ((Microsoft.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.btnAddCar = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\UserControls\ucCars.xaml"
            this.btnAddCar.Click += new System.Windows.RoutedEventHandler(this.btnAddCar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\UserControls\ucCars.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\UserControls\ucCars.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

