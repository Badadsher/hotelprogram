﻿#pragma checksum "..\..\..\Views\SignIn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7D37B84CC733AB96DF8EC294F2278D529F7AA5FD30080F863E5F4C8669244B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using System.Windows.Shell;
using Teatr.Views;


namespace Teatr.Views {
    
    
    /// <summary>
    /// SignIn
    /// </summary>
    public partial class SignIn : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 119 "..\..\..\Views\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginBox;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\Views\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label autorization;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Views\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginBT;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\Views\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passBox;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\Views\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button REG;
        
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
            System.Uri resourceLocater = new System.Uri("/Teatr;component/views/signin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SignIn.xaml"
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
            this.loginBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 119 "..\..\..\Views\SignIn.xaml"
            this.loginBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.loginBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.autorization = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.loginBT = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\..\Views\SignIn.xaml"
            this.loginBT.Click += new System.Windows.RoutedEventHandler(this.SignUpBT);
            
            #line default
            #line hidden
            return;
            case 4:
            this.passBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.REG = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\Views\SignIn.xaml"
            this.REG.Click += new System.Windows.RoutedEventHandler(this.regBT);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

