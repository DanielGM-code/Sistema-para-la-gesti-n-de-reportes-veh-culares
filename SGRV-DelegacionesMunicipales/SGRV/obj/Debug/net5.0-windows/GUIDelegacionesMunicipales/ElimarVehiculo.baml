   M S B A M L   `   `   `  ����R  NDelegacionesMunicipales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullw@clr-namespace:DelegacionesMunicipales.GUIDelegacionesMunicipales2DelegacionesMunicipales.GUIDelegacionesMunicipales  5   	   G    ADelegacionesMunicipales.GUIDelegacionesMunicipales.ElimarVehiculo   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Rlocal@clr-namespace:DelegacionesMunicipales.GUIDelegacionesMunicipales     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  ElimarVehiculo��5	   	   $	��730��6    $
��1300��6-    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      �� 5   
      border_ContenedorFormulario#��[  5      $��465,160,100,25q�5      �� 5   
   $��Eliminar Vehículo��6   $��Center=�5      $��0,18,0,0q�5      $	��Top=�5         label_textoGrande#��[ 5!      �� 5#   
   $��Nombre del conductor��6   $
��Left=�5$      $��
85,214,0,0q�5%      $	��Top=�5&        label_textoPequeño#��[ 5'      �� 5)   
   $��	Vehículo��6   $
��Left=�5*      $��
76,471,0,0q�5+      $	��Top=�5,      #��[ 5-      �� 5/   
   $��Marca��6   $
��Left=�50      $��482,214,0,0q�51      $	��Top=�52      #��[ 53      �� 55   
   $��Modelo��6   $
��Left=�56      $��482,332,0,0q�57      $	��Top=�58      #��[ 59      �� 5;   
   $
��Año��6   $
��Left=�5<      $��878,214,0,0q�5=      $	��Top=�5>      #��[ 5?      �� 5A   
   $��Color��6   $
��Left=�5B      $��882,332,0,0q�5C      $	��Top=�5D      #��[ 5E      �� 5G   
   $��Nombre de la aseguradora��6   $
��Left=�5H      $��482,458,0,0q�5I      $	��Top=�5J      #��[ 5K      �� 5M   
   $$��Número de la poliza de seguro��6   $
��Left=�5N      $��876,458,0,0q�5O      $	��Top=�5P      #��[ 5Q      �� 5S   
   $%��Número de placas del vehículo��6   $
��Left=�5T      $��482,575,0,0q�5U      $	��Top=�5V      #��[ 5W      �� 5Y   
   -   5        	 ��Name$	 tb_nombreConductor��5Y      $
��Left=�5Z      $��114,184,0,0q�5[      $	��Top=�5\      $	��275��5]      
 �� 	MaxLength$	
 250��5^        textBox_textBoxTransparente#��[ 5_      �� 5a   
   -   5        $	 tb_marca��5a      $��Center=�5b      $��	0,185,0,0q�5c      $	��Top=�5d      $	��270��5e      $	
 250��5f      #��[ 5g      �� 5i   
   -   5        $	 	tb_modelo��5i      $��Center=�5j      $��	0,303,0,0q�6/   $	��Top=�5k      $	��270��5l      $	
 250��5m      #��[ 5n      �� 5p   
   -   5        $	 tb_año��5p      $
��Left=�5q      $��912,184,0,0q�5r      $	��Top=�5s      $	��270��5t      $
 4��5u      #��[ 5v      �� 5x   
   -   5        $	 tb_color��5x      $
��Left=�5y      $��912,303,0,0q�5z      $	��Top=�5{      $	��270��5|      $	
 250��5}      #��[ 5~      �� 5�   
   -   5        $	 tb_nombreAseguradora��5�      $��Center=�5�      $��	0,429,0,0q�5�      $	��Top=�5�      $	��270��5�      $	
 250��5�      #��[ 5�      �� 5�   
   -   5        $	 tb_numeroPolizaSeguro��5�      $
��Left=�5�      $��912,429,0,0q�5�      $	��Top=�5�      $	��270��5�      $	
 250��5�      #��[ 5�      �� 5�   
   -	   5        $	 tb_numeroPlacas��5�      $��Center=�5�      $��	0,546,0,0q�5�      $	��Top=�5�      $	��270��5�      $	
 250��5�      #��[ 5�      .  (MahApps.Metro.IconPacks.PackIconMaterial  5�   
      Kind$ AccountSearch=�6%   $��
89,185,0,0q�5�   )   $��25��6=   $��20��6I     5�   
   $ RegisteredTrademark=�6%   $��486,184,0,0q�5�   )   $��25��6>   $��20��6J     5�   
   $ Calendar=�6%   $��881,184,0,0q�5�   )   $��25��6>   $��20��6J     5�   
   $	 Car=�6%   $��486,304,0,0q�5�   )   $��25��6>   $��20��6J     5�   
   $ FormatColorFill=�6%   $��882,303,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $ Numeric=�6%   $��881,432,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $ CarCog=�6%   $��486,429,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $ CarBack=�6%   $��486,546,0,0q�5�   )   $��24��6>   $��20��6J   �� 5�   
   -
   5         ��Name$ button_Eliminar��5�      $��Eliminar vehículo��5�      $
��Left=�5�      $��734,634,0,0q�5�      $	��Top=�5�        button_botonMediano#��[ 5�      5�      �� 5�   
   -   5        $ button_Regresar��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6     button_botonIcono#��[ 5�      $��	28,28,0,0q�5�   /   ��5�      /  )MahApps.Metro.IconPacks.MaterialExtension     Kind$ 	ArrowLeft=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 30Q�   Width$ 40Q�5�   /   �� 5�   
   -   5        $ button_Chat��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	85,28,0,0q�5�   +   ��5�        $ Email=�$ 30Q�$ 40Q�5�   +   �� 5�   
   -   5        $ button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Logout=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_MinimizarVentana��5�      $
��Left=�5�      $��1188,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ WindowMinimize=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Close=�$ 30Q�$ 30Q�5�      �� 5�   
     border_lineasGrandes#��[ 6   $��486,578,514,150q�6?   �� 5�   
   #��[ 6   $��882,461,118,267q�6?   �� 5�   
   #��[ 6   $��488,461,512,267q�6?   �� 5�   
   #��[ 6   $��882,335,118,393q�6?   �� 5�   
   #��[ 6   $��882,217,118,511q�6?   �� 5�   
   #��[ 6   $��486,335,514,393q�6?   �� 5�   
   #��[ 6   $��486,217,514,511q�6?   �� 5�   
   #��[ 6   $��89,217,911,511q�6?   &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ dg_conductores��5�      $��76,254,905,298q�6+      Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Nombre+  5�      $ Fecha de Nacimiento��6%    6B   �� *FechaNacimiento+  5�      $ Numero de Licencia��6%    6A   �� *NumeroLicencia+  5�      $ Telefono��6%    67   �� *
Telefono+5�        5�   
   -   5        $ dg_vehiculos��5�      $��76,506,905,46q�6)    5        5     $ Marca��6%    64   �� *Marca+  5     $ Modelo��6%    65   �� *Modelo+  5     $ Número de placas��6%    6?   �� *Placas+  5     $
 Año��6%    62   �� *Ano+  5     $ Color��6%    64   �� *Color+5     5	     5
     