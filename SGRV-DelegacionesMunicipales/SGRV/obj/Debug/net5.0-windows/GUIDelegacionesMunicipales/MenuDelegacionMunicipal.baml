   M S B A M L   `   `   `  ����R  NDelegacionesMunicipales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:SGRV.GUIDelegacionesMunicipalesSGRV.GUIDelegacionesMunicipales  5   	   =    7SGRV.GUIDelegacionesMunicipales.MenuDelegacionMunicipal   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:SGRV.GUIDelegacionesMunicipales     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  MenuDelegacionMunicipal��5	   	   $	��730��5
   	   $
��1300��6    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      �� 5   
   $N��HBienvenido al Sistema de Reportes de 
            Siniestros Vehiculares��6   $
��Left=�5      $��
277,15,0,0q�5      $	��Top=�5         label_textoGrande#��[  5      �� 5    
     border_ContenedorBotones#��[ 5!      $��232,240,718,350q�5"      �� 5$   
   #��[ 5%      $��698,240,252,350q�5&      �� 5(   
   #��[ 5)      $��465,481,485,109q�5*      �� 5-   
   -   5        	 ��Name$	 button_Conductor��5-      $��        Conductores��5.      $
��Left=�5/      $��232,240,0,0q�50      $	��Top=�51      $	��140��52      $	��350��6     button_botonGrande#��[ 53      54      �� 56   
   -   5        $	 button_Vehiculo��56      $��        Vehículos��57      $
��Left=�58      $��698,240,0,0q�59      $	��Top=�5:      $	��140��5;      $	��350��6   #��[ 5<      5=      �� 5?   
   -   5        $	 button_Reporte��5?      $��     Reportes��5@      $
��Left=�5A      $��465,481,0,0q�5B      $	��Top=�5C      $	��140��5D      $	��350��6   #��[ 5E      5F      �� 5H   
   -   5        $��button_RegistrarConductor��5I        button_botonIconoRegistrar#��[ 5K      $
��Left=�5L      $��344,280,0,0q�5M      $	��Top=�5O      $��58��6%   $��56��61   ��5J      /  )MahApps.Metro.IconPacks.MaterialExtension  3  -MahApps.Metro.IconPacks.BasePackIconExtension
   Height$
 40Q�   Kind$
 Plus=�   Width$ 40Q�5O   1   �� 5Q   
   -   5        $	 button_ModificarConductor��5R        button_botonIconoModificar#��[ 5T      $
��Left=�5U      $��412,280,0,0q�5V      $	��Top=�5W      $��58��6%   $��56��61   ��5S        $
 40Q�$ AccountEdit=�$ 40Q�5X      �� 5Z   
   -   5        $	 button_EliminarConductor��5[        button_botonIconoEliminar#��[ 5]      $
��Left=�5^      $��480,280,0,0q�5_      $	��Top=�5`      $��58��6%   $��56��61   ��5\        $ TrashCan=�$
 40Q�$ 40Q�5a      �� 5c   
   -   5        $	 button_RegistrarVehiculo��5d      #��[ 5f      $
��Left=�5h      $��828,281,0,0q�5i      $	��Top=�5j      $��58��6%   $��56��61   ��5e        $
 40Q�$
 Plus=�$ 40Q�5j   1   �� 5l   
   -	   5        $	 button_ModificarVehiculo��5m      #��[ 5o      $
��Left=�5p      $��896,281,0,0q�5q      $	��Top=�5r      $��58��6%   $��56��61   ��5n        $
 40Q�$ Pencil=�$ 40Q�5s      �� 5u   
   -
   5        $	 button_EliminarVehiculo��5v      #��[ 5x      $
��Left=�5y      $��964,281,0,0q�5z      $	��Top=�5{      $��58��6%   $��56��61   ��5w        $
 40Q�$ TrashCan=�$ 40Q�5|      �� 5~   
   -   5        $	 button_RegistrarReporte��5      #��[ 5�      $
��Left=�5�      $��616,522,0,0q�5�      $	��Top=�5�      $��58��6%   $��56��61   ��5�        $
 40Q�$
 Plus=�$ 40Q�5�      �� 5�   
   -   5        $	 button_HistorialReporte��5�      #��[ 5�      $
��Left=�5�      $��684,522,0,0q�5�      $	��Top=�5�      $��58��6%   $��56��61   ��5�        $
 40Q�$ 
ListStatus=�$ 40Q�5�      �� 5�   
   -   5        $	 button_Chat��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6     button_botonIcono#��[ 5�      $��	85,28,0,0q�5�   +   ��5�        $ Email=�$
 30Q�$ 40Q�5�   +   �� 5�   
   -   5        $	 button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Logout=�$
 30Q�$ 30Q�5�      �� 5�   
   -   5        $	 button_MinimizarVentana��5�      $
��Left=�5�      $��1188,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ WindowMinimize=�$
 30Q�$ 30Q�5�      �� 5�   
   -   5        $	 button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Close=�$
 30Q�$ 30Q�5�      .  (MahApps.Metro.IconPacks.PackIconMaterial  5�   
   -   5          Name$ icon_car��5�   %      Kind$	 Car=�5�   %   $��730,268,0,0q�5�   %   $��84��5�   %   $��74��61     5�   
   $
 Face=�6%   $��252,274,0,0q�5�   %   $��70��5�   %   $��70��61     5�   
   $ FileDocument=�6%   $��501,511,0,0q�5�   %   $��80��5�   %   $��53��61   5�      5�      