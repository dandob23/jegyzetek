﻿#pragma checksum "..\..\..\EditItemDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2BF666EEBBD5EB97046057714928E526F8BEDD59"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Controls.Ribbon;
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


namespace ToDo {
    
    
    /// <summary>
    /// EditItemDialog
    /// </summary>
    public partial class EditItemDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\EditItemDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleField;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\EditItemDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CategoryField;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\EditItemDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePicker;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\EditItemDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TimeField;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\EditItemDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ItemListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ToDo;component/edititemdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EditItemDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TitleField = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\EditItemDialog.xaml"
            this.TitleField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TitleField_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CategoryField = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\EditItemDialog.xaml"
            this.CategoryField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CategoryField_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.TimeField = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\EditItemDialog.xaml"
            this.TimeField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TimeField_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ItemListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 17 "..\..\..\EditItemDialog.xaml"
            this.ItemListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ItemListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 19 "..\..\..\EditItemDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

