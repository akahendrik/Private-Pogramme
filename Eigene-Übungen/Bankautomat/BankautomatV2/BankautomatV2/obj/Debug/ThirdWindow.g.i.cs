﻿#pragma checksum "..\..\ThirdWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1B141DD101441968D6159246DEC0258443E928450EB9FBD30DFD9FD30A767FBC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using BankautomatV2;
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


namespace BankautomatV2 {
    
    
    /// <summary>
    /// ThirdWindow
    /// </summary>
    public partial class ThirdWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label kontoinformation;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label kontostand;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label abmelden;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Kontoinformation;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Kontostand;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button abmelden1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEinzahlen;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxEinzahlung;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxAuszahlung;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AuszahlenButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BankautomatV2;component/thirdwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ThirdWindow.xaml"
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
            this.kontoinformation = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.kontostand = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.abmelden = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Kontoinformation = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\ThirdWindow.xaml"
            this.Kontoinformation.Click += new System.Windows.RoutedEventHandler(this.Kontoinformation_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Kontostand = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\ThirdWindow.xaml"
            this.Kontostand.Click += new System.Windows.RoutedEventHandler(this.Kontostand_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.abmelden1 = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ThirdWindow.xaml"
            this.abmelden1.Click += new System.Windows.RoutedEventHandler(this.Abmelden1_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonEinzahlen = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\ThirdWindow.xaml"
            this.ButtonEinzahlen.Click += new System.Windows.RoutedEventHandler(this.ButtonEinzahlen_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TextBoxEinzahlung = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.TextBoxAuszahlung = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.AuszahlenButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\ThirdWindow.xaml"
            this.AuszahlenButton.Click += new System.Windows.RoutedEventHandler(this.Button_ClickAuszahlen);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

