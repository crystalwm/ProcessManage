﻿#pragma checksum "..\..\..\2应用程序\SoftWareAppPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B6B1C127422758C7CE93B69EACFA3C3D"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.4963
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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


namespace Processes_Manage {
    
    
    /// <summary>
    /// SoftWareAppPage
    /// </summary>
    public partial class SoftWareAppPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\2应用程序\SoftWareAppPage.xaml"
        internal System.Windows.Controls.ListView appListView;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\2应用程序\SoftWareAppPage.xaml"
        internal System.Windows.Controls.Button clearLog_Button;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\2应用程序\SoftWareAppPage.xaml"
        internal System.Windows.Controls.Button checkHistory_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/Processes_Manage;component/2%e5%ba%94%e7%94%a8%e7%a8%8b%e5%ba%8f/softwareapppage" +
                    ".xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\2应用程序\SoftWareAppPage.xaml"
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
            this.appListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.clearLog_Button = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\2应用程序\SoftWareAppPage.xaml"
            this.clearLog_Button.Click += new System.Windows.RoutedEventHandler(this.clearLog_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.checkHistory_Button = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\2应用程序\SoftWareAppPage.xaml"
            this.checkHistory_Button.Click += new System.Windows.RoutedEventHandler(this.checkHistory_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
