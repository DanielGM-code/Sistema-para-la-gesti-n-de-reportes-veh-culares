   M S B A M L   `   `   `  ����K  GDireccionGeneral, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SGRV.GUIDireccionGeneralSGRV.GUIDireccionGeneral  5   	   3    -SGRV.GUIDireccionGeneral.MenuDireccionGeneral   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SGRV.GUIDireccionGeneral     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6>   -   5          � Title$  MenuDireccionGeneral��5   	   $	��730��5	   	   $
��1300��6    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      �� 5   
      border_ContenedorBotones#��[  5      $��232,240,718,350q�5      �� 5   
   #��[  5      $��698,240,252,350q�5      �� 5!   
   #��[  5"      $��465,481,485,109q�5#      �� 5%   
   $K��EBienvenido al Sistema de Reportes 
         de Siniestros Vehiculares��6   $��Center=�5&      $	��Top=�5'        label_textoGrande#��[ 5(      $��0,14,0,0q�6;   �� 5+   
   -   5        	 ��Name$	 button_Chat��5+      $
��Left=�5-      $	��Top=�5.      $��44��5/      $��52��6     button_botonIcono#��[ 50      $��	85,28,0,0q�51   +   ��5,      /  )MahApps.Metro.IconPacks.MaterialExtension  
   Kind$
 Email=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 30Q�   Width$ 40Q�51   +   �� 53   
   -   5        $	 button_CerrarSesion��53      $
��Left=�55      $��1140,28,0,0q�56      $��44��57      $��42��6   $	��Top=�58      #��[ 59      ��54        $
 Logout=�$ 30Q�$ 30Q�5:      �� 5<   
   -   5        $	 button_MinimizarVentana��5<      $
��Left=�5>      $��1188,28,0,0q�5?      $��44��5@      $��42��6   $	��Top=�5A      #��[ 5B      ��5=        $
 WindowMinimize=�$ 30Q�$ 30Q�5C      �� 5E   
   -   5        $	 button_CerrarVentana��5E      $
��Left=�5G      $��1234,28,0,0q�5H      $��44��5I      $��42��6   $	��Top=�5J      #��[ 5K      ��5F        $
 Close=�$ 30Q�$ 30Q�5L      �� 5N   
   -   5        $	 button_Usuario��5N      $��        Usuarios��5O      $
��Left=�5P      $��232,240,0,0q�5Q      $	��Top=�5R      $	��140��5S      $	��350��6     button_botonGrande#��[ 5T      5U      �� 5W   
   -   5        $$	 button_DelegacionesMunicipales��5W      $6��0           Delegaciones 
            municipales��5X      $
��Left=�5Y      $	��Top=�5Z      $	��140��5[      $	��350��6   #��[ 5\      $��Center=�5^      $��Center=�5_      $��465,481,0,0q�5`      �� 5b   
   -   5        $	 button_Reporte��5b      $��     Reportes��5c      $
��Left=�5d      $��698,240,0,0q�5e      $	��Top=�5f      $	��140��5g      $	��350��6   #��[ 5h      5i      �� 5k   
   -	   5        $��button_RegistrarUsuario��5l        button_botonIconoRegistrar#��[ 5n      $
��Left=�5o      $��344,280,0,0q�5p      $	��Top=�5r      $��58��6%   $��56��61   ��5m        $ 40Q�$

 Plus=�$ 40Q�5r   1   �� 5t   
   -
   5        $	 button_ModificarUsuario��5u        button_botonIconoModificar#��[ 5w      $
��Left=�5x      $��412,280,0,0q�5y      $	��Top=�5z      $��58��6%   $��56��61   ��5v        $ 40Q�$
 AccountEdit=�$ 40Q�5{      �� 5}   
   -   5        $	 button_EliminarUsuario��5~        button_botonIconoEliminar#��[ 5�      $
��Left=�5�      $��480,280,0,0q�5�      $	��Top=�5�      $��58��6%   $��56��61   ��5        $
 TrashCan=�$ 40Q�$ 40Q�5�      �� 5�   
   -   5        $	 button_VisualizarReporte��5�      #��[ 5�      $
��Left=�5�      $��886,281,0,0q�5�      $	��Top=�5�      $��58��6%   $��56��61   $ 0.634,0.457&�5�   4   ��5�        $ 50Q�$	
 Eye=�$ 50Q�5�   4   �� 5�   
   -   5        $ 	 button_RegistrarDelegacion��5�      #��[ 5�      $
��Left=�5�      $��584,522,0,0q�5�      $	��Top=�5�      $��58��6%   $��56��61   ��5�        $ 40Q�$

 Plus=�$ 40Q�5�      �� 5�   
   -   5        $ 	 button_ModificarDelegacion��5�      #��[ 5�      $
��Left=�5�      $��652,522,0,0q�5�      $	��Top=�5�      $��58��6%   $��56��61   ��5�        $ 40Q�$
 BookEdit=�$ 40Q�5�      �� 5�   
   -   5        $	 button_EliminarDelegacion��5�      #��[ 5�      $
��Left=�5�      $��720,522,0,0q�5�      $	��Top=�5�      $��58��6%   $��56��61   ��5�        $
 TrashCan=�$ 40Q�$ 40Q�5�      .  (MahApps.Metro.IconPacks.PackIconMaterial  5�   
      Kind$
 Face=�6%   $��252,274,0,0q�5�   %   $��70��5�   %   $��70��61     5�   
   -   5          Name$ icon_car��5�   %   $ FileDocument=�5�   %   $��730,268,0,0q�5�   %   $��84��5�   %   $��74��61     5�   
   $
 City=�6%   $��501,511,0,0q�5�   %   $��80��5�   %   $��53��61   5�      5�      