﻿#pragma checksum "..\..\..\..\GUIDireccionGeneral\VizualizarReporte.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D8380E0EA97A2D42347750BF471DE9CEA26EB9F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using SGRV.GUIDireccionGeneral;
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


namespace SGRV.GUIDireccionGeneral {
    
    
    /// <summary>
    /// VizualizarReporte
    /// </summary>
    public partial class VizualizarReporte : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\..\GUIDireccionGeneral\VizualizarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CerrarSesion;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\GUIDireccionGeneral\VizualizarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Chat;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\GUIDireccionGeneral\VizualizarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Regresar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DireccionGeneral;component/guidirecciongeneral/vizualizarreporte.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUIDireccionGeneral\VizualizarReporte.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.button_CerrarSesion = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\GUIDireccionGeneral\VizualizarReporte.xaml"
            this.button_CerrarSesion.Click += new System.Windows.RoutedEventHandler(this.button_CerrarSesion_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.button_Chat = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\GUIDireccionGeneral\VizualizarReporte.xaml"
            this.button_Chat.Click += new System.Windows.RoutedEventHandler(this.button_Chat_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button_Regresar = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\GUIDireccionGeneral\VizualizarReporte.xaml"
            this.button_Regresar.Click += new System.Windows.RoutedEventHandler(this.button_Regresar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

