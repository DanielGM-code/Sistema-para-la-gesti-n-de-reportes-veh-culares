   M S B A M L   `   `   `  ����R  NDelegacionesMunicipales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:SGRV.GUIDelegacionesMunicipalesSGRV.GUIDelegacionesMunicipales  5   	   8    2SGRV.GUIDelegacionesMunicipales.RegistrarConductor   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:SGRV.GUIDelegacionesMunicipales     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6E   -   5          � Title$  RegistrarConductor��5   	   $	��730��5	   	   $
��1300��6    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      �� 5   
      border_ContenedorFormulario#��[  5      $��218,211,234,113q�5      �� 5   
   $��Registro de conductor��6   $��Center=�5      $��0,25,0,0q�5      $	��Top=�5         label_textoGrande#��[ 5!      �� 5#   
   -   5        	 ��Name$	 	tb_nombre��5#      $
��Left=�5$      $��265,247,0,0q�5%      
 �� TextWrapping$
 NoWrap=�5&      $	��Top=�5'      $	��275��5(       �� 	MaxLength$	 250��5)        textBox_textBoxTransparente#��[ 5*      �� 5,   
   -   5        $	 tb_licencia��5,      $
��Left=�5-      $��265,417,0,0q�5.      $
 NoWrap=�5/      $	��Top=�50      $	��275��51      $ 10��52      #��[ 53      6G   �� 55   
   -   5        $	 tb_telefono��55      $
��Left=�56      $��764,417,0,0q�57      $
 NoWrap=�58      $	��Top=�59      $	��275��5:      $ 10��5;      #��[ 5=      6G   �� 5?   
   -   5         ��Name$ button_Registrar��5?      $��Registrar conductor��5@      $
��Left=�5A      $��542,533,0,0q�5B      $	��Top=�5C        button_botonMediano#��[ 5D      5E      �� 5G   
   $��Nombre Completo��6   $
��Left=�5H      $��234,279,0,0q�5I      $	��Top=�5J        label_textoPequeño#��[ 5K      �� 5M   
   $��Fecha de Nacimiento��6   $
��Left=�5N      $��735,279,0,0q�5O      $	��Top=�5P      #��[ 5Q      �� 5S   
   $��Numero de Licencia��6   $
��Left=�5T      $��234,449,0,0q�5U      $	��Top=�5V      #��[ 5W      �� 5Y   
   $��Telefono celular:��6   $
��Left=�5Z      $��735,449,0,0q�5[      $	��Top=�5\      #��[ 5]      �� 5_   
     border_lineasGrandes#��[ 6   $��240,449,760,279q�6?   �� 5a   
   #��[ 6   $��739,449,261,279q�6?   �� 5c   
   #��[ 6   $��240,279,760,449q�6?   �� 5e   
   #��[ 6   $��739,279,261,449q�6?   .  (MahApps.Metro.IconPacks.PackIconMaterial  5h   
      Kind$ 	RenameBox=�6%   $��240,247,0,0q�5i   %   $��28��5j   %   $��20��61   5k        5m   
   $ Calendar=�6%   $��739,246,0,0q�5n   %   $��28��5o   %   $��20��61   5p        5r   
   $ Numeric=�6%   $��240,421,0,0q�5s   %   $��23��5t   %   $��20��61   5u        5w   
   $ CellphoneBasic=�6%   $��739,421,0,0q�5x   %   $��23��5y   %   $��20��61   5z      (  "System.Windows.Controls.DatePicker  5}   
   -   5          Name$ dp_fehcaNacimiento��5}      $
��Left=�5~      $��764,244,0,0q�5      $	��Top=�5�      $��30��5�      $	��275��6!   �� 5�   
   -   5        $ button_Regresar��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6     button_botonIcono#��[ 5�      $��	28,28,0,0q�5�   /   ��5�      /  )MahApps.Metro.IconPacks.MaterialExtension     Kind$ 	ArrowLeft=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 30Q�   Width$ 40Q�5�   /   �� 5�   
   -   5        $ button_Chat��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	85,28,0,0q�5�   +   ��5�        $ Email=�$ 30Q�$ 40Q�5�   +   �� 5�   
   -	   5        $ button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Logout=�$ 30Q�$ 30Q�5�      �� 5�   
   -
   5        $ button_MinimizarVentana��5�      $
��Left=�5�      $��1188,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ WindowMinimize=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Close=�$ 30Q�$ 30Q�5�      5�      5�      