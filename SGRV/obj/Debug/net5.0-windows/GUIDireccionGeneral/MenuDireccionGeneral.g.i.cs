﻿#pragma checksum "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6AE52BF1CCFBB4985AFB268D0189D55C29874980"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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
    /// MenuDireccionGeneral
    /// </summary>
    public partial class MenuDireccionGeneral : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Chat;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CerrarSesion;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_MinimizarVentana;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CerrarVentana;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_RegistroUsuarios;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_RegistroDelegacionesMunicipales;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_VizualizarReportes;
        
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
            System.Uri resourceLocater = new System.Uri("/SGRV;V1.0.0.0;component/guidirecciongeneral/menudirecciongeneral.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
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
            
            #line 12 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
            ((SGRV.GUIDireccionGeneral.MenuDireccionGeneral)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Login_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.button_Chat = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
            this.button_Chat.Click += new System.Windows.RoutedEventHandler(this.button_Chat_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button_CerrarSesion = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
            this.button_CerrarSesion.Click += new System.Windows.RoutedEventHandler(this.button_CerrarSesion_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_MinimizarVentana = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
            this.button_MinimizarVentana.Click += new System.Windows.RoutedEventHandler(this.button_MinimizarVentana_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_CerrarVentana = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
            this.button_CerrarVentana.Click += new System.Windows.RoutedEventHandler(this.button_CerrarVentana_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_RegistroUsuarios = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
            this.button_RegistroUsuarios.Click += new System.Windows.RoutedEventHandler(this.button_RegistroUsuarios_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button_RegistroDelegacionesMunicipales = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
            this.button_RegistroDelegacionesMunicipales.Click += new System.Windows.RoutedEventHandler(this.button_RegistroDelegacionesMunicipales_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button_VizualizarReportes = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\..\GUIDireccionGeneral\MenuDireccionGeneral.xaml"
            this.button_VizualizarReportes.Click += new System.Windows.RoutedEventHandler(this.button_VizualizarReportes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

