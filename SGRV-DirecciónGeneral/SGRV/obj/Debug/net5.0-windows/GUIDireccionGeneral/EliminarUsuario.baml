   M S B A M L   `   `   `  ����K  GDireccionGeneral, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:DireccionGeneral.GUIDireccionGeneral$DireccionGeneral.GUIDireccionGeneral  5   	   :    4DireccionGeneral.GUIDireccionGeneral.EliminarUsuario   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:DireccionGeneral.GUIDireccionGeneral     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  EliminarUsuario��5	   	   $	��730��6"   $
��1300��6/    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��381* �6   �� 5      $
��349* �6   .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#   	 � Offset$		 0.0Q�63   � 5      $ #3f4977��6#   $	 1Q�63   5      5      �� 5   
   $��Eliminar usuario��6   $��Center=�5      $��0,18,0,0q�5      $	��Top=�5         label_textoGrande#��[  5       �� 5"   
     border_ContenedorFormulario#��[ 6   $��508,248,84,140q�6F   $��2��6^   �� 5#   
     border_lineasGrandes#��[ 6   $��546,312,454,67q�6?   �� 5$   
   #��[ 6   $��546,47,454,300q�6?   $��1��6W   �� 5&   
   $��Nombre de usuario��6   $
��Left=�5'      $��540,312,0,0q�5(      $	��Top=�5)        label_textoPequeño#��[ 5*      �� 5,   
   $��Cargo��6   $
��Left=�5-      $��880,310,0,0q�5.      $	��Top=�5/      #��[ 50      $ 
0.23,0.578&�6<   �� 52   
   $��Delegación��6   $
��Left=�53      $��
880,47,0,0q�54      $	��Top=�55      #��[ 56      $��1��6<   �� 58   
   $��Correo��6   $
��Left=�59      $��
542,45,0,0q�5:      $	��Top=�5;      #��[ 5<      $��1��6<   �� 5>   
   -   5        
 ��Name$
 tb_username��5>      $
��Left=�5?      $��574,280,0,0q�5@       �� TextWrapping$
 Wrap=�5A      $	��Top=�5B       �� 
IsReadOnly$
 True��5C      $	��272��5D       �� 	MaxLength$	 250��5E        textBox_textBoxTransparente#��[ 5F      �� 5H   
   -   5        $
 	tb_correo��5H      $
��Left=�5I      $��
574,15,0,0q�5J      $	��Top=�5K      $	��270��5L      $
 True��5M      $	 250��5N      #��[ 5O      $��1��6G   �� 5Q   
   -   5         ��Name$ cb_cargo��5Q      $
��Left=�5R      $��914,280,0,0q�5S      $	��Top=�5T       �� 
IsReadOnly$
 True��5U      $��13(�5V      $	��270��5X      $��24��6   ��5W      �� *cargos+5X      �� 5Z   
   -   5        $ cb_delegacion��5Z      $
��Left=�5[      $��
914,15,0,0q�5\      $
 True��5]      $��13(�5^      $	��Top=�5_      $	��270��5`      $��26��6   $��1��6+   �� 5b   
   -   5         ��Name$ button_Eliminar��5b      $��Eliminar usuario��5c      $
��Left=�5d      $��762,125,0,0q�5e      $	��Top=�5f        button_botonMediano#��[ 5g      $��1��5h   /   �� 5j   
   -   5        $ button_Regresar��5j      $
��Left=�5l      $	��Top=�5m      $��44��5n      $��52��6     button_botonIcono#��[ 5o      $��	28,28,0,0q�5p   /   ��5k      /  )MahApps.Metro.IconPacks.MaterialExtension     Kind$ 	ArrowLeft=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 30Q�   Width$ 40Q�5p   /   �� 5r   
   -   5        $ button_Chat��5r      $
��Left=�5t      $	��Top=�5u      $��44��5v      $��52��6   #��[ 5w      $��	85,28,0,0q�5x   +   ��5s        $ Email=�$ 30Q�$ 40Q�5x   +   �� 5z   
   -	   5        $ button_Buscar��5z      $
��Left=�5|      $��Center=�5}      $��Center=�5~      $	��Top=�5      $��34��5�      $��39��6   #��[ 5�      $��
92,154,0,0q�5�   -   ��5{        $ AccountSearch=�$ 24Q�$ 20Q�5�   -   �� 5�   
   -
   5        $ button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Logout=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_MinimizarVentana��5�      $
��Left=�5�      $��1188,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ WindowMinimize=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Close=�$ 30Q�$ 30Q�5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ 
dg_Usarios��5�      $��80,240,901,140q�6'   $��2��6d      Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre de usuario��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *
Username+  5�      $ Cargo��6%    64   �� *Cargo+  5�      $ Delegación��6%    69   �� *
Delegacion+  5�      $ Correo electrónico��6%    6A   �� *Correo+5�      �� 5�   
   #��[ 6   $��92,193,908,186q�6?   �� 5�   
   $��Usuario��6   $
��Left=�5�      $��
86,191,0,0q�5�      $	��Top=�5�      #��[ 5�      �� 5�   
   -   5        $
 
tb_Usuario��5�      $
��Left=�5�      $��136,161,0,0q�5�      $	��Top=�5�      $	��256��5�      $	 250��5�      #��[ 5�      �� 5�   
   #��[ 6   $��886,314,114,65q�6?   �� 5�   
   #��[ 6   $��886,47,114,300q�6?   $��1��6W   .  (MahApps.Metro.IconPacks.PackIconMaterial  5�   
      Kind$ Account=�6%   $��547,280,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $ 	Briefcase=�6%   $��886,280,0,0q�5�      $��24��6"   $��20��6.   $ 	0.65,0.25&�69     5�   
   $
 City=�6%   $��
886,15,0,0q�5�      $��24��6!   $��20��6-   $ 	0.65,0.25&�68   $��1��6Z     5�   
   $ Gmail=�6%   $��
546,15,0,0q�5�      $��24��6!   $��20��6-   $ 	0.65,0.25&�68   $��1��6Z   5�      5�      