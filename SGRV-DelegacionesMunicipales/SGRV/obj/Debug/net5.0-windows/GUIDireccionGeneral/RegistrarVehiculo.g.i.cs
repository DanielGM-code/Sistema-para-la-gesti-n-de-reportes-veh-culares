// Updated by XamlIntelliSenseFileGenerator 05/06/2021 07:53:44 p. m.
#pragma checksum "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "760EE0EE70D8D8D9270645234F9D63E125BE36DF"
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
using SGRV.GUIDelegacionesMunicipales;
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


namespace SGRV.GUIDelegacionesMunicipales
{


    /// <summary>
    /// RegistrarVehiculo
    /// </summary>
    public partial class RegistrarVehiculo : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 164 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Registrar;

#line default
#line hidden


#line 178 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Regresar;

#line default
#line hidden


#line 186 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Chat;

#line default
#line hidden


#line 194 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CerrarSesion;

#line default
#line hidden


#line 203 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_MinimizarVentana;

#line default
#line hidden


#line 212 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CerrarVentana;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SGRV;V1.0.0.0;component/guidirecciongeneral/registrarvehiculo.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 12 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
                    ((SGRV.GUIDelegacionesMunicipales.RegistrarVehiculo)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseDown);

#line default
#line hidden
                    return;
                case 2:
                    this.tb_nombreConductor = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.tb_marca = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.tb_modelo = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.tb_año = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.tb_color = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.tb_nombreAseguradora = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.tb_numeroPolizaSeguro = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 9:
                    this.tb_numeroPlacas = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 10:
                    this.button_Registrar = ((System.Windows.Controls.Button)(target));

#line 170 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
                    this.button_Registrar.Click += new System.Windows.RoutedEventHandler(this.button_Registrar_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.button_Regresar = ((System.Windows.Controls.Button)(target));

#line 184 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
                    this.button_Regresar.Click += new System.Windows.RoutedEventHandler(this.button_Regresar_Click);

#line default
#line hidden
                    return;
                case 12:
                    this.button_Chat = ((System.Windows.Controls.Button)(target));

#line 192 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
                    this.button_Chat.Click += new System.Windows.RoutedEventHandler(this.button_Chat_Click);

#line default
#line hidden
                    return;
                case 13:
                    this.button_CerrarSesion = ((System.Windows.Controls.Button)(target));

#line 201 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
                    this.button_CerrarSesion.Click += new System.Windows.RoutedEventHandler(this.button_CerrarSesion_Click);

#line default
#line hidden
                    return;
                case 14:
                    this.button_MinimizarVentana = ((System.Windows.Controls.Button)(target));

#line 210 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
                    this.button_MinimizarVentana.Click += new System.Windows.RoutedEventHandler(this.button_MinimizarVentana_Click);

#line default
#line hidden
                    return;
                case 15:
                    this.button_CerrarVentana = ((System.Windows.Controls.Button)(target));

#line 219 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
                    this.button_CerrarVentana.Click += new System.Windows.RoutedEventHandler(this.button_CerrarVentana_Click);

#line default
#line hidden
                    return;
                case 16:
                    this.dg_conductores = ((System.Windows.Controls.DataGrid)(target));

#line 238 "..\..\..\..\GUIDireccionGeneral\RegistrarVehiculo.xaml"
                    this.dg_conductores.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.clic_conductor_item);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox tb_nombreDelegacion;
        internal System.Windows.Controls.TextBox tb_nombre;
        internal System.Windows.Controls.TextBox tb_municipio;
        internal System.Windows.Controls.TextBox tb_direccion;
        internal System.Windows.Controls.TextBox tb_telefono;
        internal System.Windows.Controls.TextBox tb_codigoPostal;
        internal System.Windows.Controls.TextBox tb_correo;
        internal System.Windows.Controls.DataGrid dg_DelegacionesMunicipales;
    }
}
