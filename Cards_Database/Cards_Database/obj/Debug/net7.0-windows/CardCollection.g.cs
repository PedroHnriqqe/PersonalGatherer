﻿#pragma checksum "..\..\..\CardCollection.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5D2564EACC952F4871717E8CB04CFDE7170FB86D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cards_Database;
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


namespace Cards_Database {
    
    
    /// <summary>
    /// CardCollection
    /// </summary>
    public partial class CardCollection : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\CardCollection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\CardCollection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refreshBtn;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\CardCollection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homeBtn;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\CardCollection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl CardPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Cards_Database;component/cardcollection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CardCollection.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            
            #line 39 "..\..\..\CardCollection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddCard_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 40 "..\..\..\CardCollection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeckBuilding_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.refreshBtn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\CardCollection.xaml"
            this.refreshBtn.Click += new System.Windows.RoutedEventHandler(this.RefreshBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.homeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\CardCollection.xaml"
            this.homeBtn.Click += new System.Windows.RoutedEventHandler(this.homeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CardPanel = ((System.Windows.Controls.ItemsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

