   M S B A M L   `   `   `  ����R  NDelegacionesMunicipales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullw@clr-namespace:DelegacionesMunicipales.GUIDelegacionesMunicipales2DelegacionesMunicipales.GUIDelegacionesMunicipales  5   	   J    DDelegacionesMunicipales.GUIDelegacionesMunicipales.VisualizarReporte   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Rlocal@clr-namespace:DelegacionesMunicipales.GUIDelegacionesMunicipales     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  VisualizarReporte��5	   	   $	��730��6#   $
��1300��60    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      .  (MahApps.Metro.IconPacks.PackIconMaterial  5   
   	   Kind$	 Calendar=�6%   $��681,142,0,0q�5      $��26��6"   $��27��6.     5   
   $		 Map=�6%   $��981,142,0,0q�5      $��26��6"   $��28��6.   �� 5   
      border_lineas#��[  5      $��681,176,359,552q�5       �� 5"   
   #��[  5#      $��981,176,59,552q�5$      �� 5&   
   $��Visualizar Reporte��5'      $��Center=�5(      $��0,18,0,0q�5)      $	��Top=�5*        label_textoGrande#��[ 5+      &   System.Windows.Controls.DataGrid  5-   
   -   5        
  Name$
 dg_reportes��5.      $��59,210,981,170q�5/         Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	IdReporte+  53      $ Fecha��6%    64   �� *Fecha+  54      $ 
Dirección��6%    68   �� *	Direccion+56        58   
   -   5        $!
 dg_conductoresSeleccionados��59      $��368,254,674,294q�5:      �� 5<   
   $ ��Conductores seleccionados:��5=      $
��Left=�5>      $��368,224,0,0q�5?      $	��Top=�5@        label_textoPequeño#��[ 5A        5C   
   -   5        $
 dg_vehiculosSeleccionados��5D      $��368,482,675,72q�5E      �� 5G   
   $��Vehículos seleccionados:��5H      $
��Left=�5I      $��368,456,0,0q�5J      $	��Top=�5K      #��[ 5L      $ 0.609,0.231&�69   �� 5N   
   $��Fecha��5O      $
��Left=�5P      $��675,176,0,0q�5Q      $	��Top=�5R      #��[ 5S      �� 5U   
   $��
Dirección��5V      $
��Left=�5W      $��975,176,0,0q�5X      $	��Top=�5Y      #��[ 5Z      �� 5\   
   -   5         ��Name$ tb_direccion��5]      $
��Left=�5^      $��1021,142,0,0q�5_      $	��Top=�5`      $	��220��5a       �� 	MaxLength$	 250��5b      ${�False��5c        textBox_textBoxTransparente#��[ 5d      �� 5f   
   $��Descripción:��5g      $
��Left=�5h      $��681,220,0,0q�5i      $	��Top=�5j      #��[ 5k      �� 5m   
   -   5        $ tb_Descripcion��5n      ${�False��5o      $
��Left=�5p      $��685,254,0,0q�5q      $	��Top=�5r      $	��555��5s      $	��182��6   $	 250��5t        textBox_textBoxGrande#��[ 5u      �� 5w   
   -   5         ��Name$ button_VerDictamen��5x      $��Ver dictamen��5y      $
��Left=�5z      $��
85,608,0,0q�5{      $	��Top=�5|        button_botonMediano#��[ 5}      5~      �� 5�   
   -   5        $ button_Regresar��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6     button_botonIcono#��[ 5�      $��	28,28,0,0q�5�   /   ��5�      /  )MahApps.Metro.IconPacks.MaterialExtension     Kind$ 	ArrowLeft=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 30Q�   Width$ 40Q�5�   /   �� 5�   
   -	   5        $ button_Chat��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	85,28,0,0q�5�   +   ��5�        $ Email=�$ 30Q�$ 40Q�5�   +   �� 5�   
   -
   5        $ button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Logout=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_MinimizarVentana��5�      $
��Left=�5�      $��1188,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ WindowMinimize=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Close=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_BuscarReporte��5�      $
��Left=�5�      $	��Top=�5�      $��40��5�      $��35��6   #��[ 5�      $��
55,140,0,0q�5�   4   ��5�        $ AccountSearch=�$ 25Q�$ 26Q�5�   4   �� 5�   
   #��[  5�      $��59,176,981,552q�5�      �� 5�   
   $��Reportes��5�      $
��Left=�5�      $��
55,178,0,0q�5�      $	��Top=�5�      #��[ 5�      �� 5�   
   -   5        $ tb_busqueda��5�      $
��Left=�5�      $��
94,144,0,0q�5�      $	��Top=�5�      $	��225��5�      $	 250��5�      #��[ 5�      (  "System.Windows.Controls.DatePicker  5�   
   -   5          Name$ dp_fecha��5�      $
��Left=�5�      $��717,140,0,0q�5�      $	��Top=�5�      $	��224��5�      ${�False��5�      � 5�   
   -   5         �Name$ wp_imagenes��5�      $��732,479,108,69q�5�      5�      �� 5�   
     border_ContenedorFormulario#��[ 5�      $��682,474,58,64q�5�      5�      5�      