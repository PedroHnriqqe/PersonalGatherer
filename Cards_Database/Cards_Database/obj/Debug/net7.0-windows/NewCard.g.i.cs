﻿#pragma checksum "..\..\..\NewCard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ED5EB79758E52B57065BEBB25F83A29B3E443C6"
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
    /// NewCard
    /// </summary>
    public partial class NewCard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\NewCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameInput;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\NewCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cardType;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\NewCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox collectionInput;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\NewCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox marketPlaceInput;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\NewCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addNewBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\NewCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageDisplay;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\NewCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertImage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Cards_Database;component/newcard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NewCard.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nameInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cardType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.collectionInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.marketPlaceInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.addNewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\NewCard.xaml"
            this.addNewBtn.Click += new System.Windows.RoutedEventHandler(this.addNewBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.imageDisplay = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.InsertImage = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\NewCard.xaml"
            this.InsertImage.Click += new System.Windows.RoutedEventHandler(this.InsertImage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

