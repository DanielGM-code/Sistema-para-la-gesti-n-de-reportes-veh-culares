   M S B A M L   `   `   `  ����K  GDireccionGeneral, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SGRVSGRV  5   	       
SGRV.Login   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:SGRV     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   4
Syncfusion!http://schemas.syncfusion.com/wpf   5   	   -   5          � Title$  
MainWindow��5   	   $	��450��5   	   $	��380��6    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 25��6   $��2��6'    J� RenderTransformOrigin$ 0.513,0.427&�68    J� Opacity$	 0.9Q�6\   ��5      �� 5      .��5      � 	 � Color$	 #006a65��6'   
 � Offset$	
 0.0Q�67   � 5      $	 #3f4977��6'   $
 1Q�67   5      5      �� 5!      -   5         ��Name$ button_CerrarVentana��5!      $��Right=�5"      $��
0,9,19,201q�5#         button_botonPequeno#��[  5$      $��X��5%      5&      �� 5)      -   5         ��Name$ tb_username��5)      $
��Left=�5*        textBox_textBoxTransparente#��[ 5+      $
��Left=�5,      $	��225��5-      $��25��5.      $��
99,200,0,0q�5/      .  (MahApps.Metro.IconPacks.PackIconMaterial  51      -   5          Name$ icon_usernameWhite��52   )      Kind$ Account=�53   )   $��
64,200,0,0q�54   )   $��25��6=   $��20��6I   �� 56        border_lineas#��[ 57      $��64,5,56,218q�58      $��1��6&   �� 5:      #��[ 6   $��64,91,56,132q�6<   $��1��6R   G� 5<      -   5         G�Name$ pb_password��5<       ' #passwordBox_passwordBoxTransparente#��[ 5=      $
��Left=�5>      $��25��5?      $��99,62,56,138q�6*   $��1��6@     5A      -   5        $ icon_passwordWhite��5B      $ FormTextboxPassword=�5C      $��	64,62,0,0q�5D      $��1��61   $��24��6>   $��20��6J   �� 5G      $��Nombre de Usuario��6   $
��Left=�5H      $��60,5,0,0q�5I      $��1��5J      $	��Top=�5K        label_textoPequeño#��[ 5L      �� 5O      $��Contraseña��6   $
��Left=�5P      $��	60,91,0,0q�5Q      $��1��5R      $	��Top=�5S      #��[ 5T      �� 5W      $��Sistema De Gestión��6   $��Center=�5X      $��	0,121,0,0q�5Y      $	��Top=�5Z        label_textoMediano#��[ 5[      �� 5\      $��De Reportes Vehiculares��6   $��Center=�5]      $��	0,147,0,0q�5^      $	��Top=�5_      #��[ 5`      �� 5b      -   5        $ button_IniciarSesion��5b        button_botonMediano#��[ 5c      $��Iniciar Sesión��5d      $��1��5e   @   $��
0,152,0,23q�5f      $��Center=�5g      �� 5i      $
��Left=�6   $	��104��5j      $��	99,16,0,0q�6!   $	��Top=�5k      $	��188��6,   $��/LogoSGRV.png��68   5l      5m      5n      