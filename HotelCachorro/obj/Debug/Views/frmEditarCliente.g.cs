﻿#pragma checksum "..\..\..\Views\frmEditarCliente.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6CBDC2EF0CD5D7AE32A4369B1ADB81226A346B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelCachorro.Views;
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


namespace HotelCachorro.Views {
    
    
    /// <summary>
    /// frmEditarCliente
    /// </summary>
    public partial class frmEditarCliente : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\frmEditarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\frmEditarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrarCliente;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\frmEditarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCriadoEm;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\frmEditarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRg;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\frmEditarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCpf;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\frmEditarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefone;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\frmEditarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboGeneros;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\frmEditarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\frmEditarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpDataNascimento;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\frmEditarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxTSobrenome;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelCachorro;component/views/frmeditarcliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\frmEditarCliente.xaml"
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
            this.txtNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnCadastrarCliente = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Views\frmEditarCliente.xaml"
            this.btnCadastrarCliente.Click += new System.Windows.RoutedEventHandler(this.EditarCliente);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtCriadoEm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtRg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtCpf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtTelefone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cboGeneros = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\frmEditarCliente.xaml"
            this.btnBuscar.Click += new System.Windows.RoutedEventHandler(this.ProcurarCliente);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\Views\frmEditarCliente.xaml"
            this.btnBuscar.Loaded += new System.Windows.RoutedEventHandler(this.CaaregarXX);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dtpDataNascimento = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.TxTSobrenome = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

