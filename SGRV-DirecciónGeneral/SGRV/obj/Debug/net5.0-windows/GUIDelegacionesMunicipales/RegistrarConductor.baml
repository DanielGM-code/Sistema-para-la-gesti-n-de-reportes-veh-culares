   M S B A M L   `   `   `  ����?  ;SGRV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:SGRV.GUIDelegacionesMunicipalesSGRV.GUIDelegacionesMunicipales  5   	   8    2SGRV.GUIDelegacionesMunicipales.RegistrarConductor   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:SGRV.GUIDelegacionesMunicipales     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6E   -   5          � Title$  RegistrarConductor��5   	   $	��730��5	   	   $
��1300��6    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6    J� RenderTransformOrigin$ 0.513,0.427&�6#   ��5      �� 5      .��5      �  � Color$ #202639��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      �� 5   
   $��Registro de conductor��6   $��Center=�5      $��0,25,0,0q�5      $	��Top=�5         label_textoGrande#��[  5      �� 5   
   -   5        	 ��Name$	 	tb_nombre��5      $
��Left=�5       $��265,247,0,0q�5!      
 �� TextWrapping$
 NoWrap=�5"      $	��Top=�5#      $	��275��5$        textBox_textBoxTransparente#��[ 5%      �� 5'   
   -   5        $	 tb_licencia��5'      $
��Left=�5(      $��265,440,0,0q�5)      $
 NoWrap=�5*      $	��Top=�5+      $	��275��5,      #��[ 5-      �� 5/   
   -   5        $	 tb_telefono��5/      $
��Left=�50      $��764,440,0,0q�51      $
 NoWrap=�52      $	��Top=�53      $	��275��54      #��[ 55      �� 57   
   -   5         ��Name$ button_Registrar��57      $��Registrar conductor��58      $
��Left=�59      $��580,585,0,0q�5:      $	��Top=�5;        button_botonMediano#��[ 5<      5=      �� 5?   
   $��Nombre Completo��6   $
��Left=�5@      $��234,279,0,0q�5A      $	��Top=�5B        label_textoPequeño#��[ 5C      �� 5E   
   $��Fecha de Nacimiento��6   $
��Left=�5F      $��735,279,0,0q�5G      $	��Top=�5H      #��[ 5I      �� 5K   
   $��Numero de Licencia��6   $
��Left=�5L      $��234,472,0,0q�5M      $	��Top=�5N      #��[ 5O      �� 5Q   
   $��Telefono celular:��6   $
��Left=�5R      $��735,472,0,0q�5S      $	��Top=�5T      #��[ 5U      �� 5W   
     border_lineasGrandes#��[ 6   $��240,472,760,256q�6?   �� 5Y   
   #��[ 6   $��739,472,261,256q�6?   �� 5[   
   #��[ 6   $��240,279,760,449q�6?   �� 5]   
   #��[ 6   $��739,279,261,449q�6?   .  (MahApps.Metro.IconPacks.PackIconMaterial  5`   
      Kind$ Email=�6%   $��	91,35,0,0q�5a   %   $��30��5b   %   $��40��61   5c        5e   
   $ 	ArrowLeft=�6%   $��	34,35,0,0q�5f   %   $��30��5g   %   $��40��61   5h        5j   
   $ Logout=�6%   $��1146,35,0,0q�5k   %   $��30��5l   %   $��30��61   5m        5o   
   $ WindowMinimize=�6%   $��1193,35,0,0q�5p   %   $��30��5q   %   $��30��61   5r        5t   
   $ Close=�6%   $��1240,35,0,0q�5u   %   $��30��5v   %   $��30��61   5w        5y   
   $ 	RenameBox=�6%   $��240,247,0,0q�5z   %   $��28��5{   %   $��20��61   5|        5~   
   $ Calendar=�6%   $��739,246,0,0q�5   %   $��28��5�   %   $��20��61   5�        5�   
   $ Numeric=�6%   $��240,444,0,0q�5�   %   $��23��5�   %   $��20��61   5�        5�   
   $ CellphoneBasic=�6%   $��739,444,0,0q�5�   %   $��23��5�   %   $��20��61   5�      (  "System.Windows.Controls.DatePicker  5�   
   -   5          Name$ dp_fehcaNacimiento��5�      $
��Left=�5�      $��764,244,0,0q�5�      $	��Top=�5�      $��30��5�      $	��275��6!   �� 5�   
   -   5        $ button_Chat��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6     button_botonIcono#��[ 5�      $��	85,28,0,0q�5�   +   �� 5�   
   -   5        $ button_Regresar��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	28,28,0,0q�5�   /   �� 5�   
   -	   5        $ button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      5�      �� 5�   
   -
   5        $ button_MinimizarVentana��5�      $
��Left=�5�      $��1187,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      5�      �� 5�   
   -   5        $ button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      5�      5�      5�      