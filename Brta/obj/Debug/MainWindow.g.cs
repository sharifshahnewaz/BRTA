﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8D5F38820EAA71E2813132E058F7D1D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Brta {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.Menu menus;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.MenuItem nmuAddNew;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.MenuItem mnuExit;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.MenuItem mnuChangePW;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.MenuItem mnuChangeDB;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.Grid grdLeftButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.StackPanel stpButtonHolder;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.Button btnTools;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.Button btnHistory;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.Button btnEmergency;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.Button btnUser;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.Grid mainGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Brta;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.menus = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.nmuAddNew = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.mnuExit = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.mnuChangePW = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.mnuChangeDB = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            this.grdLeftButton = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.stpButtonHolder = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.btnTools = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.btnTools.Click += new System.Windows.RoutedEventHandler(this.btnTools_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnHistory = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\MainWindow.xaml"
            this.btnHistory.Click += new System.Windows.RoutedEventHandler(this.btnHistory_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnEmergency = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.btnEmergency.Click += new System.Windows.RoutedEventHandler(this.btnEmergency_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnUser = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\MainWindow.xaml"
            this.btnUser.Click += new System.Windows.RoutedEventHandler(this.btnUser_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
