   M S B A M L   `   `   `  ����K  GDireccionGeneral, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SGRV.GUIDireccionGeneralSGRV.GUIDireccionGeneral  5   	   2    ,SGRV.GUIDireccionGeneral.ModificarDelegacion   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SGRV.GUIDireccionGeneral     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  ModificarDelegacion��5	   	   $	��730��5
   	   $
��1300��6    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      �� 5   
      border_ContenedorFormulario#��[  5      $��465,204,100,48q�5      �� 5   
   $0��*Modificación de  Delegaciones Municipales��6   $��Center=�5      $��0,18,0,0q�5       $	��Top=�5!        label_textoGrande#��[ 5"      �� 5$   
   $��Delegación municipal��6   $
��Left=�5%      $��
85,214,0,0q�5&      $	��Top=�5'        label_textoPequeño#��[ 5(      �� 5*   
   $��Nombre o alias��6   $
��Left=�5+      $��482,258,0,0q�5,      $	��Top=�5-      #��[ 5.      �� 50   
   $��
Dirección��6   $
��Left=�51      $��482,376,0,0q�52      $	��Top=�53      #��[ 54      �� 56   
   $��	Municipio��6   $
��Left=�57      $��878,258,0,0q�58      $	��Top=�59      #��[ 5:      �� 5<   
   $��	Teléfono��6   $
��Left=�5=      $��882,376,0,0q�5>      $	��Top=�5?      #��[ 5@      �� 5B   
   $��Código postal��6   $
��Left=�5C      $��482,502,0,0q�5D      $	��Top=�5E      #��[ 5F      �� 5H   
   $��Correo electrónico��6   $
��Left=�5I      $��876,502,0,0q�5J      $	��Top=�5K      #��[ 5L      �� 5N   
   -   5        	 ��Name$	 tb_nombreDelegacion��5N      $
��Left=�5O      $��138,184,0,0q�5P      $	��Top=�5Q      $	��251��5R      
 �� 	MaxLength$	
 250��5S        textBox_textBoxTransparente#��[ 5T      �� 5V   
   -   5        $	 	tb_nombre��5V      $��Center=�5W      $��	0,230,0,0q�5X      $	��Top=�5Y      $	��270��5Z      $	
 250��5[      #��[ 5\      �� 5^   
   -   5        $	 tb_direccion��5^      $��Center=�5_      $��	0,348,0,0q�6/   $	��Top=�5`      $	��270��5a      $	
 250��5b      #��[ 5c      �� 5e   
   -   5         ��Name$ cb_municipio��5e      $��911,228,119,477q�5f      $��13(�5g      ��5h      �� *
municipios+�� 5j   
   -   5        $	 tb_telefono��5j      $
��Left=�5k      $��912,348,0,0q�5l      $	��Top=�5m      $	��270��5n      $
 10��5o      #��[ 5p      6G   �� 5r   
   -   5        $	 tb_codigoPostal��5r      $��Center=�5s      $��	0,474,0,0q�5t      $	��Top=�5u      $	��270��5v      $	
 250��5w      #��[ 5x      6G   �� 5z   
   -   5        $	 	tb_correo��5z      $
��Left=�5{      $��912,474,0,0q�5|      $	��Top=�5}      $	��270��5~      $	
 250��5      #��[ 5�      �� 5�   
   -	   5         ��Name$ button_Buscar��5�      $
��Left=�5�      $��Center=�5�      $��Center=�5�      $	��Top=�5�      $��34��5�      $��39��6     button_botonIcono#��[ 5�      $��
89,178,0,0q�5�   -   ��5�      /  )MahApps.Metro.IconPacks.MaterialExtension     Kind$ TextBoxSearch=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 24Q�   Width$ 20Q�5�   -   .  (MahApps.Metro.IconPacks.PackIconMaterial  5�   
      Kind$ 	RenameBox=�6%   $��486,228,0,0q�5�   )   $��26��6>   $��20��6J     5�   
   $
 City=�6%   $��881,228,0,0q�5�   )   $��26��6>   $��20��6J     5�   
   $	 Map=�6%   $��486,348,0,0q�5�   )   $��26��6>   $��20��6J     5�   
   $ CellphoneBasic=�6%   $��882,348,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $ Gmail=�6%   $��881,476,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $ Numeric=�6%   $��486,474,0,0q�5�   )   $��24��6>   $��20��6J   �� 5�   
   -
   5        $ button_Modificar��5�      $0��*Modificar delegación 
          municipal��5�      $
��Left=�5�      $��732,602,0,0q�5�      $	��Top=�5�        button_botonMediano#��[ 5�      $��57��5�   0   �� 5�   
   -   5        $ button_Regresar��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	28,28,0,0q�5�   /   ��5�        $ 	ArrowLeft=�$ 30Q�$ 40Q�5�   /   �� 5�   
   -   5        $ button_Chat��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	85,28,0,0q�5�   +   ��5�        $ Email=�$ 30Q�$ 40Q�5�   +   �� 5�   
   -   5        $ button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Logout=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_MinimizarVentana��5�      $
��Left=�5�      $��1188,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ WindowMinimize=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Close=�$ 30Q�$ 30Q�5�      �� 5�   
     border_lineasGrandes#��[ 6   $��882,506,118,222q�6?   �� 5�   
   #��[ 6   $��488,506,512,222q�6?   �� 5�   
   #��[ 6   $��882,380,118,348q�6?   �� 5�   
   #��[ 6   $��882,262,118,466q�6?   �� 5�   
   #��[ 6   $��486,380,514,348q�6?   �� 5�   
   #��[ 6   $��486,262,514,466q�6?   �� 5�   
   #��[ 6   $��89,217,911,511q�6?   &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$  dg_DelegacionesMunicipales��5�      $��76,254,905,48q�67      Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Nombre+  5�      $ 	Municipio��6%    68   �� *	Municipio+  5�      $ 	Direccion��6%    68   �� *	Direccion+  5�      $ Telefono��6%    67   �� *
Telefono+  5�      $ Código postal��6%    6<   �� *CodigoPostal+  5�      $ Correo electrónico��6%    6A   �� *Correo+5�      5�      5�      