﻿#pragma checksum "..\..\..\UserControls\ucUsers.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F00A7498621BE8B3645E74CB4313CAE1"
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
    /// ucUsers
    /// </summary>
    public partial class ucUsers : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\UserControls\ucUsers.xaml"
        internal System.Windows.Controls.ComboBox cboType;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UserControls\ucUsers.xaml"
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UserControls\ucUsers.xaml"
        internal System.Windows.Controls.TextBox txtUserID;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UserControls\ucUsers.xaml"
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\UserControls\ucUsers.xaml"
        internal Microsoft.Windows.Controls.DataGrid dtgUsers;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\UserControls\ucUsers.xaml"
        internal System.Windows.Controls.Button btnAddUser;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\UserControls\ucUsers.xaml"
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\UserControls\ucUsers.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Brta;component/usercontrols/ucusers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\ucUsers.xaml"
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
            this.cboType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\UserControls\ucUsers.xaml"
            this.cboType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\UserControls\ucUsers.xaml"
            this.txtName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtUserID = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\UserControls\ucUsers.xaml"
            this.txtUserID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtUserID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\UserControls\ucUsers.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.btnClear_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtgUsers = ((Microsoft.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.btnAddUser = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\UserControls\ucUsers.xaml"
            this.btnAddUser.Click += new System.Windows.RoutedEventHandler(this.btnAddUser_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\UserControls\ucUsers.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\UserControls\ucUsers.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

