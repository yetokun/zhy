﻿#pragma checksum "..\..\DefenseCircleSetting.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FEF418E9D54E45B1C7B00624F1116A0F"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
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
using System.Windows.Forms.Integration;
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


namespace MaritimeSecurityMonitoring {
    
    
    /// <summary>
    /// DefenseCircleSetting
    /// </summary>
    public partial class DefenseCircleSetting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 61 "..\..\DefenseCircleSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox circleRadius;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\DefenseCircleSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox circleColor;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\DefenseCircleSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox circleName;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\DefenseCircleSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox circleRank;
        
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
            System.Uri resourceLocater = new System.Uri("/MaritimeSecurityMonitoring;component/defensecirclesetting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DefenseCircleSetting.xaml"
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
            
            #line 5 "..\..\DefenseCircleSetting.xaml"
            ((MaritimeSecurityMonitoring.DefenseCircleSetting)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.dragMoveWindow);
            
            #line default
            #line hidden
            
            #line 5 "..\..\DefenseCircleSetting.xaml"
            ((MaritimeSecurityMonitoring.DefenseCircleSetting)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\DefenseCircleSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.closeWindowClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.circleRadius = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\DefenseCircleSetting.xaml"
            this.circleRadius.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.circleColor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.circleName = ((System.Windows.Controls.TextBox)(target));
            
            #line 90 "..\..\DefenseCircleSetting.xaml"
            this.circleName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.circleRank = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 116 "..\..\DefenseCircleSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.saveClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 117 "..\..\DefenseCircleSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cancelClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

