   M S B A M L   `   `   `  ����R  NDelegacionesMunicipales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:SGRV.GUIDelegacionesMunicipalesSGRV.GUIDelegacionesMunicipales  5   	   6    0SGRV.GUIDelegacionesMunicipales.RegistrarReporte   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:SGRV.GUIDelegacionesMunicipales     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  RegistrarReporte��5	   	   $	��730��5
   	   $
��1300��6    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      .  (MahApps.Metro.IconPacks.PackIconMaterial  5   
   	   Kind$		 Map=�6%   $��1000,96,0,0q�5      $��26��6"   $��28��6.   �� 5   
      border_ContenedorFormulario#��[  5      $��700,413,40,124q�5       �� 5"   
     border_lineas#��[ 5#      $��41,129,999,599q�5$      �� 5&   
   #��[ 5'      $��340,128,700,600q�5(      �� 5*   
   #��[ 5+      $��700,129,340,599q�5,      �� 5.   
   #��[ 5/      $��1000,129,40,599q�50      �� 52   
   $��Registrar Reporte��53      $��Center=�54      $��0,18,0,0q�55      $	��Top=�56        label_textoGrande#��[ 57      &   System.Windows.Controls.DataGrid  59   
   -   5        
  Name$
 dg_conductores��5:      $��41,165,1000,367q�5;      5<        5>   
   -   5        $
 dg_vehiculos��5?      $��340,165,700,367q�5@      5A      �� 5C   
   $��Conductor(es)��5D      $
��Left=�5E      $��
38,129,0,0q�5F      $	��Top=�5G        label_textoPequeño#��[ 5H      �� 5J   
   $��
Vehículos��5K      $
��Left=�5L      $��336,129,0,0q�5M      $	��Top=�5N      #��[ 5O      �� 5Q   
   -   5         ��Name$ tb_busquedaConductor��5R      $
��Left=�5S      $��	75,96,0,0q�5T      $	��Top=�5U       �� 	MaxLength$	 250��5V        textBox_textBoxTransparente#��[ 5W      $	��225��6B     5Y   
   -   5        $!
 dg_conductoresSeleccionados��5Z      $��41,406,1000,147q�5[      5\      �� 5^   
   $ ��Conductores seleccionados:��5_      $
��Left=�5`      $��
41,382,0,0q�5a      $	��Top=�5b      #��[ 5c      �� 5e   
   -   5        $ tb_busquedaVehiculo��5f      $
��Left=�5g      $��
375,95,0,0q�5h      $	��Top=�5i      $	��225��5j      $	 250��5k      #��[ 5l        5n   
   -   5        $
 dg_vehiculosSeleccionados��5o      $��343,406,700,147q�5p      6&   �� 5r   
   $��Vehículos seleccionados:��5s      $
��Left=�5t      $��343,382,0,0q�5u      $	��Top=�5v      #��[ 5w      $ 0.609,0.231&�69   �� 5y   
   $��Fecha��5z      $
��Left=�5{      $��694,129,0,0q�5|      $	��Top=�5}      #��[ 5~      �� 5�   
   $��
Dirección��5�      $
��Left=�5�      $��994,129,0,0q�5�      $	��Top=�5�      #��[ 5�      �� 5�   
   -   5        $ tb_direccion��5�      $
��Left=�5�      $��1040,96,0,0q�5�      $	��Top=�5�      $	��220��5�      $	 250��5�      #��[ 5�      �� 5�   
   $��Descripción:��5�      $
��Left=�5�      $��700,174,0,0q�5�      $	��Top=�5�      #��[ 5�      �� 5�   
   -	   5        $ tb_descripcion��5�      $
��Left=�5�      $��700,205,0,0q�5�      $	��Top=�5�      $	��560��5�      $	��158��6   $	 250��5�        textBox_textBoxGrande#��[ 5�      �� 5�   
   $��Fotografías:��5�      $
��Left=�5�      $��702,382,0,0q�5�      $	��Top=�5�      #��[ 5�      �� 5�   
   -
   5         ��Name$ button_BuscarConductor��5�      $
��Left=�5�      $	��Top=�5�      $��40��5�      $��35��6     button_botonIcono#��[ 5�      $��	35,90,0,0q�5�   6   ��5�      /  )MahApps.Metro.IconPacks.MaterialExtension     Kind$ AccountSearch=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 25Q�   Width$ 26Q�5�   6   �� 5�   
   -   5        $ button_BuscarVehículo��5�      $
��Left=�5�      $	��Top=�5�      $��40��5�      $��35��6   #��[ 5�      $��
335,90,0,0q�5�   5   ��5�        $	 Car=�$ 25Q�$ 26Q�5�   5   �� 5�   
   -   5        $ button_RegistrarReporte��5�      $��Registrar reporte��5�      $��Center=�5�      $��	0,640,0,0q�5�      $	��Top=�5�        button_botonMediano#��[ 5�      5�      � 5�   
   -   5         �Name$ wp_imagenes��5�      $��750,413,90,135q�5�      5�      �� 5�   
   -   5        $ button_agregarFotografia��5�      $��1209,423,51,267q�5�        button_botonIconoRegistrar#��[ 5�      $��40��5�   4   $��40��6@   ��5�        $ 30Q�$
 Plus=�$ 30Q�5�   @   �� 5�   
   -   5        $ btn_eliminarConductor��5�      $��Quitar��5�      $��41,583,1225,124q�5�      #��[ 5�      $
��Auto��5�   1   $
��Auto��6?   �� 5�   
   -   5        $ btn_eliminarVehiculo��5�      $��Quitar��5�      $��343,583,924,124q�5�      #��[ 5�      $
��Auto��69   $
��Auto��6G   6T   �� 5�   
   -   5        $ button_Regresar��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	28,28,0,0q�5�   /   ��5�        $ 	ArrowLeft=�$ 30Q�$ 40Q�5�   /   �� 5�   
   -   5        $ button_Chat��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	85,28,0,0q�5�   +   ��5�        $ Email=�$ 30Q�$ 40Q�5�   +   �� 5�   
   -   5        $ button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Logout=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_MinimizarVentana��5�      $
��Left=�5�      $��1188,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ WindowMinimize=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5      $��42��6   $	��Top=�5     #��[ 5     ��5�        $ Close=�$ 30Q�$ 30Q�5     (  "System.Windows.Controls.DatePicker  5  
   -   5          Name$ dp_fecha��5     $
��Left=�6(   $��
700,96,0,0q�6C   $	��Top=�6W   5     5     