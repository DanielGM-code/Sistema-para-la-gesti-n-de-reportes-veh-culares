   M S B A M L   `   `   `  ����R  NDelegacionesMunicipales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:SGRV.GUIDelegacionesMunicipalesSGRV.GUIDelegacionesMunicipales  5   	   8    2SGRV.GUIDelegacionesMunicipales.ModificarConductor   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:SGRV.GUIDelegacionesMunicipales     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  ModificarConductor��5	   	   $	��730��5
   	   $
��1300��6    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      �� 5   
      border_ContenedorFormulario#��[  5      $��485,177,91,147q�5      �� 5   
   $��	Conductor��6   $
��Left=�5      $��
75,211,0,0q�5      $	��Top=�5         label_textoPequeño#��[ 5!      �� 5#   
   -   5        	 ��Name$	 tb_nombreConductor��5#      $
��Left=�5$      $��115,185,0,0q�5%      $	��Top=�5&      
 �� 	MaxLength$	
 250��5'        textBox_textBoxTransparente#��[ 5(      $	��265��6B   �� 5*   
   $ ��Modificación de conductor��6   $��Center=�5+      $��0,25,0,0q�5,      $	��Top=�5-        label_textoGrande#��[ 5.      �� 50   
   -   5        $	 	tb_nombre��50      $
��Left=�51      $��549,213,0,0q�52       �� TextWrapping$ NoWrap=�53      $	��Top=�54      $	��275��55      $	
 250��56      #��[ 57      �� 59   
   -   5        $	 tb_licencia��59      $
��Left=�5:      $��549,383,0,0q�5;      $ NoWrap=�5<      $	��Top=�5=      $	��275��5>      $
 10��5?      #��[ 5@      6G   �� 5B   
   -   5        $	 tb_telefono��5B      $
��Left=�5C      $��907,383,0,0q�5D      $ NoWrap=�5E      $	��Top=�5F      $	��275��5G      $
 10��5H      #��[ 5I      6G   �� 5K   
   -   5         ��Name$ button_Modificar��5K      $��Modificar conductor��5L      $
��Left=�5M      $��747,500,0,0q�5N      $	��Top=�5O        button_botonMediano#��[ 5P      5Q      �� 5S   
   $��Nombre Completo��6   $
��Left=�5T      $��518,243,0,0q�5U      $	��Top=�5V      #��[ 5W      �� 5Y   
   $��Fecha de Nacimiento��6   $
��Left=�5Z      $��878,245,0,0q�5[      $	��Top=�5\      #��[ 5]      �� 5_   
   $��Numero de Licencia��6   $
��Left=�5`      $��518,415,0,0q�5a      $	��Top=�5b      #��[ 5c      �� 5e   
   $��Telefono celular:��6   $
��Left=�5f      $��878,415,0,0q�5g      $	��Top=�5h      #��[ 5i      �� 5k   
     border_lineasGrandes#��[ 6   $��524,415,476,313q�6?   �� 5m   
   #��[ 6   $��882,415,118,313q�6?   �� 5o   
   #��[ 6   $��524,245,476,483q�6?   �� 5q   
   #��[ 6   $��80,215,920,513q�6?   �� 5s   
   #��[ 6   $��882,245,118,483q�6?   .  (MahApps.Metro.IconPacks.PackIconMaterial  5w   
      Kind$ 	RenameBox=�6%   $��524,213,0,0q�5x   %   $��28��5y   %   $��20��61   5z        5|   
   $ Calendar=�6%   $��882,212,0,0q�5}   %   $��28��5~   %   $��20��61   5        5�   
   $ Numeric=�6%   $��524,387,0,0q�5�   %   $��23��5�   %   $��20��61   5�        5�   
   $ CellphoneBasic=�6%   $��882,383,0,0q�5�   %   $��27��5�   %   $��20��61   5�      (  "System.Windows.Controls.DatePicker  5�   
   -   5          Name$ dp_fehcaNacimiento��5�      $
��Left=�5�      $��907,210,0,0q�5�      $	��Top=�5�      $��30��5�      $	��275��6!   �� 5�   
   -   5        $ button_Buscar��5�      $
��Left=�5�      $	��Top=�5�      $��40��5�      $��35��6     button_botonIcono#��[ 5�      $��
75,178,0,0q�5�   -   ��5�      /  )MahApps.Metro.IconPacks.MaterialExtension     Kind$ AccountSearch=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 25Q�   Width$ 26Q�5�   -   �� 5�   
   -	   5        $ button_Regresar��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	28,28,0,0q�5�   /   ��5�        $ 	ArrowLeft=�$ 30Q�$ 40Q�5�   /   �� 5�   
   -
   5        $ button_Chat��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	85,28,0,0q�5�   +   ��5�        $ Email=�$ 30Q�$ 40Q�5�   +   �� 5�   
   -   5        $ button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Logout=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_MinimizarVentana��5�      $
��Left=�5�      $��1188,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ WindowMinimize=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Close=�$ 30Q�$ 30Q�5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ dg_conductores��5�      $��80,242,901,147q�6+      Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Nombre+  5�      $ Fecha de Nacimiento��6%    6B   �� *FechaNacimiento+  5�      $ Numero de Licencia��6%    6A   �� *NumeroLicencia+  5�      $ Telefono��6%    67   �� *
Telefono+5�      5�      5�      