   M S B A M L   `   `   `  ����?  ;SGRV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:SGRV.GUIDelegacionesMunicipalesSGRV.GUIDelegacionesMunicipales  5   	   6    0SGRV.GUIDelegacionesMunicipales.RegistrarReporte   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:SGRV.GUIDelegacionesMunicipales     5   	     � Title$  RegistrarReporte��5   	   $	��768��6"   $
��1366��6/   .��5	      � .+�5
   
   �� $��Registrar Reporte��6   $��Center=�6,   $��0,10,0,0q�6I   $	��Top=�6[   $��40(�6s   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_conductores��5      $��57,172,1060,355q�6+   6D     5   
   -   5        $ dg_vehiculos��5      $��343,172,774,355q�6)   6B   �� 5   
   $��Conductores��6   $
��Left=�6&   $��
62,104,0,0q�6A   $	��Top=�6U   �� 5   
   $��
Vehículos��6   $
��Left=�6$   $��343,104,0,0q�6?   $	��Top=�6T   �� 5   
   $
��Left=�6   $��
62,135,0,0q�6-   $��TextBox��6A    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��120��6|     5   
   -   5        $! dg_conductoresSeleccionados��5      $��57,472,1060,104q�68   6Q   �� 5   
   $ ��Conductores seleccionados:��6   $
��Left=�65   $��
57,441,0,0q�6P   $	��Top=�6d   �� 5   
   $
��Left=�6   $��348,135,0,0q�6-   $��TextBox��6B   $
 Wrap=�6Q   $	��Top=�6e   $	��120��6}     5   
   -   5        $ dg_vehiculosSeleccionados��5      $��343,472,774,104q�66   �� 5   
   $��Vehículos seleccionados:��6   $
��Left=�63   $��343,441,0,0q�6N   $	��Top=�6c   �� 5   
   $��Fecha:��6   $
��Left=�6!   $��722,104,0,0q�6<   $	��Top=�6Q   �� 5   
   $
��Left=�6   $��722,135,0,0q�6-   $��TextBox��6B   $
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   �� 5   
   $��
Dirección��6   $
��Left=�6$   $��1004,104,0,0q�6?   $	��Top=�6U   �� 5   
   $
��Left=�6   $��1004,135,0,0q�6-   $��TextBox��6C   $
 Wrap=�6R   $	��Top=�6f   $	��120��6~   �� 5   
   $��Descripción:��6   $
��Left=�6'   $��722,173,0,0q�6B   $	��Top=�6W   �� 5   
   $
��Left=�6   $��722,204,0,0q�6-   $��TextBox��6B   $
 Wrap=�6Q   $	��Top=�6e   $	��584��6}   $	��173��6�   �� 5   
   $��Fotografías:��6   $
��Left=�6'   $��723,409,0,0q�6B   $	��Top=�6W   �� 5   
   -   5         ��Name$ button_RegistrarReporte��5      $��Registrar reporte��62   $��Center=�6N   $��	0,706,0,0q�6k   $	��Top=�6~   6�   �� 5   
   -   5        $ button_CerrarSesion��5      $��Cerrar sesion��6.   $
��Left=�6F   $��1275,20,0,0q�6a   $	��Top=�6v   $��60��6�   $��60��6�   6�   �� 5   
   -   5        $ button_Chat��5      $
��Chat��6&   $
��Left=�65   $	��Top=�6P   $	��110��6h   $	��110��6u   6�   �� 5   
   -   5        $ button_Regresar��5      $
��Left=�6*   $	��Top=�6E   $	��154��6]   $��78��6j   $��-12,-49,0,0q�6u    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5       V� 5!      .~�5"      �� �� 5#      �� 5$       �� Angle$ 45.018Q�6&   T� 5%      5&      5(      � 5)   
   -	   5         �Name$ wp_imagenes��5)      $��720, 450, 65, 70q�6)   5*      �� 5+   
   -
   5        $ button_agregarFotografia��5+      $��Agregar Fotografia��63   $
��Left=�6P   $��1201,691,0,0q�6k   $	��Top=�6�   6�   �� 5,   
   -   5        $ btn_eliminarConductor��5,      $��Eliminar��60   $
��Left=�6C   $��254,658,0,0q�6^   $	��Top=�6s   6�   �� 5-   
   -   5        $ btn_eliminarVehiculo��5-      $��Eliminar��6/   $
��Left=�6B   $��546,658,0,0q�6]   $	��Top=�6r   5/      50      