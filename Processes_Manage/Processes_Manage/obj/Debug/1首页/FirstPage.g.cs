﻿#pragma checksum "..\..\..\1首页\FirstPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F6FA5F062ABA0B898230199B2B1F4128"
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
    /// FirstPage
    /// </summary>
    public partial class FirstPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\1首页\FirstPage.xaml"
        internal System.Windows.Controls.TextBlock systemTimeNow_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\1首页\FirstPage.xaml"
        internal System.Windows.Controls.TextBlock systemUsingTime_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\1首页\FirstPage.xaml"
        internal System.Windows.Controls.TextBlock netWorkState_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\1首页\FirstPage.xaml"
        internal System.Windows.Controls.TextBlock IpAddress_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\1首页\FirstPage.xaml"
        internal System.Windows.Controls.TextBlock IpSubnet_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\1首页\FirstPage.xaml"
        internal System.Windows.Controls.TextBlock cpuRate_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\1首页\FirstPage.xaml"
        internal System.Windows.Controls.ProgressBar cpu_ProgressBar;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\1首页\FirstPage.xaml"
        internal System.Windows.Controls.TextBlock memoryRate_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\1首页\FirstPage.xaml"
        internal System.Windows.Controls.ProgressBar memory_ProgressBar;
        
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
            System.Uri resourceLocater = new System.Uri("/Processes_Manage;component/1%e9%a6%96%e9%a1%b5/firstpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\1首页\FirstPage.xaml"
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
            
            #line 4 "..\..\..\1首页\FirstPage.xaml"
            ((Processes_Manage.FirstPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.systemTimeNow_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.systemUsingTime_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.netWorkState_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.IpAddress_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.IpSubnet_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.cpuRate_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.cpu_ProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            
            #line 35 "..\..\..\1首页\FirstPage.xaml"
            this.cpu_ProgressBar.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ProgressBar_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 36 "..\..\..\1首页\FirstPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cpuUsageLine_Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.memoryRate_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.memory_ProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            
            #line 43 "..\..\..\1首页\FirstPage.xaml"
            this.memory_ProgressBar.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ProgressBar_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 44 "..\..\..\1首页\FirstPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.memoryUsageLine_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
