   M S B A M L   `   `   `  ����K  GDireccionGeneral, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:DireccionGeneral.GUIDireccionGeneral$DireccionGeneral.GUIDireccionGeneral  5   	   <    6DireccionGeneral.GUIDireccionGeneral.DictaminarReporte   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:DireccionGeneral.GUIDireccionGeneral     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  DictaminarReporte��5	   	   $	��500��6#   $
��1000��60    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      �� 5   
   $��Dictaminar reporte��6   $��Center=�5      $��0,18,0,0q�5      $	��Top=�5         label_textoGrande#��[  5      �� 5   
   $��Folio único��5      $
��Left=�5       $��
81,170,0,0q�5!      $	��Top=�5"        label_textoPequeño#��[ 5#      �� 5%   
   $��Nombre del perito��5&      $
��Left=�5'      $��672,170,0,0q�5(      $	��Top=�5)      #��[ 5*      �� 5,   
   $��Descripción:��5-      $
��Left=�5.      $��
66,226,0,0q�5/      $	��Top=�50      #��[ 51      �� 53   
   $��Fecha��54      $
��Left=�55      $��371,170,0,0q�56      $	��Top=�57      #��[ 58      $ 
0.37,0.488&�69   �� 5:   
   -   5        	 ��Name$	 button_MinimizarVentana��5:      $
��Left=�5<      $��
885,28,0,0q�5=      $��44��5>      $��42��6   $	��Top=�5?        button_botonIcono#��[ 5@      ��5;      /  )MahApps.Metro.IconPacks.MaterialExtension  
   Kind$
 WindowMinimize=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 30Q�   Width$ 30Q�5A      �� 5C   
   -   5        $	 button_CerrarVentana��5C      $
��Left=�5E      $��
932,28,0,0q�5F      $��44��5G      $��42��6   $	��Top=�5H      #��[ 5I      ��5D        $
 Close=�$ 30Q�$ 30Q�5J      �� 5L   
   -   5         ��Name$ tb_Folio��5M      $
��Left=�5N      $��120,136,0,0q�5O      $	��Top=�5P      $	��225��5Q       �� 	MaxLength$	 250��5R       �� 
IsReadOnly$
 True��5S        textBox_textBoxTransparente#��[ 5T      (  "System.Windows.Controls.DatePicker  5V   
   -   5          Name$ dp_fecha��5V      $
��Left=�5W      $��412,136,0,0q�5X      $	��Top=�5Y      $	��224��5Z      ${�False��5[      �� 5]   
   -   5         ��Name$ 	cb_perito��5]      $
��Left=�5^      $��712,134,0,0q�5_       �� 
IsReadOnly$
 True��5`      $��13(�5a      $	��Top=�5b      $	��225��5c      $��26��6   �� 5e   
   -   5        $ tb_Descripcion��5f      $
��Left=�5g      $	��Top=�5h      $	��852��5i      $	��128��6   $	 250��5j        textBox_textBoxGrande#��[ 5k      $��
66,258,0,0q�6<   .  (MahApps.Metro.IconPacks.PackIconMaterial  5m   
      Kind$ 
Identifier=�6%   $��
85,136,0,0q�5n      $��24��6!   $��27��6-     5q   
   $ Calendar=�6%   $��376,134,0,0q�5r      $��26��6"   $��27��6.     5u   
   $ Account=�6%   $��677,134,0,0q�5v      $��26��6"   $��27��6.   �� 5x   
     border_lineas#��[ 5y      $��85,166,655,332q�5z      �� 5|   
   #��[ 5}      $��376,166,364,332q�5~      �� 5�   
   #��[ 5�      $��677,166,63,332q�5�      �� 5�   
   -   5        $	 button_RegistrarDictamen��5�      $��
Dictaminar��5�      $��Center=�5�      $��	0,413,0,0q�5�      $	��Top=�5�        button_botonMediano#��[ 5�      5�      5�      5�      