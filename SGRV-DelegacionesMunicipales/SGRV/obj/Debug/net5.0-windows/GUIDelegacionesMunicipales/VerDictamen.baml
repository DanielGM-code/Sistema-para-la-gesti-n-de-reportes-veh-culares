   M S B A M L   `   `   `  ����R  NDelegacionesMunicipales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullw@clr-namespace:DelegacionesMunicipales.GUIDelegacionesMunicipales2DelegacionesMunicipales.GUIDelegacionesMunicipales  5   	   D    >DelegacionesMunicipales.GUIDelegacionesMunicipales.VerDictamen   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   Nlocal@clr-namespace:DelegacionesMunicipales.GUIDelegacionesMunicipales   5   	   -   5          � Title$  VerDictamen��5	   	   $	��500��5
   	   $
��1000��6    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      �� 5   
   $��Ver Dictamen��6   $��Center=�5      $��0,18,0,0q�5      $	��Top=�5         label_textoGrande#��[  5      �� 5   
   $��Folio único��5       $
��Left=�5!      $��
81,170,0,0q�5"      $	��Top=�5#        label_textoPequeño#��[ 5$      �� 5&   
   $��Nombre del perito��5'      $
��Left=�5(      $��672,170,0,0q�5)      $	��Top=�5*      #��[ 5+      �� 5-   
   $��Descripción:��5.      $
��Left=�5/      $��
66,226,0,0q�50      $	��Top=�51      #��[ 52      �� 54   
   $��Fecha��55      $
��Left=�56      $��371,170,0,0q�57      $	��Top=�58      #��[ 59      $ 
0.37,0.488&�69   �� 5;   
   -   5        	 ��Name$	 button_MinimizarVentana��5;      $
��Left=�5=      $��
885,28,0,0q�5>      $��44��5?      $��42��6   $	��Top=�5@        button_botonIcono#��[ 5A      ��5<      /  )MahApps.Metro.IconPacks.MaterialExtension  
   Kind$
 WindowMinimize=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 30Q�   Width$ 30Q�5B      �� 5D   
   -   5        $	 button_CerrarVentana��5D      $
��Left=�5F      $��
932,28,0,0q�5G      $��44��5H      $��42��6   $	��Top=�5I      #��[ 5J      ��5E        $
 Close=�$ 30Q�$ 30Q�5K      �� 5M   
   -   5         ��Name$ tb_Folio��5N      $
��Left=�5O      $��120,136,0,0q�5P      $	��Top=�5Q      $	��225��5R       �� 	MaxLength$	 250��5S       �� 
IsReadOnly$
 True��5T        textBox_textBoxTransparente#��[ 5U      (  "System.Windows.Controls.DatePicker  5W   
   -   5          Name$ dp_fecha��5W      $
��Left=�5X      $��412,136,0,0q�5Y      $	��Top=�5Z      $	��224��5[      ${�False��5\      �� 5^   
   -   5         ��Name$ 	cb_perito��5^      $
��Left=�5_      $��712,134,0,0q�5`       �� 
IsReadOnly$
 True��5a      $��13(�5b      $	��Top=�5c      $	��225��5d      $��26��6   �� 5f   
   -   5        $ tb_Descripcion��5g      $
��Left=�5h      $	��Top=�5i      $	��852��5j      $	��128��6   $	 250��5k        textBox_textBoxGrande#��[ 5l      $��
66,258,0,0q�6<   .  (MahApps.Metro.IconPacks.PackIconMaterial  5n   
      Kind$ 
Identifier=�6%   $��
85,136,0,0q�5o      $��24��6!   $��27��6-     5r   
   $ Calendar=�6%   $��376,134,0,0q�5s      $��26��6"   $��27��6.     5v   
   $ Account=�6%   $��677,134,0,0q�5w      $��26��6"   $��27��6.   �� 5y   
     border_lineas#��[ 5z      $��85,166,655,332q�5{      �� 5}   
   #��[ 5~      $��376,166,364,332q�5      �� 5�   
   #��[ 5�      $��677,166,63,332q�5�      5�      5�      