   M S B A M L   `   `   `  ����K  GDireccionGeneral, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SGRV.GUIDireccionGeneralSGRV.GUIDireccionGeneral  5   	   2    ,SGRV.GUIDireccionGeneral.RegistrarDelegacion   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SGRV.GUIDireccionGeneral     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  RegistrarDelegacion��5	   	   $	��730��5
   	   $
��1300��6    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#    � Offset$	 0.0Q�63   � 5      $ #3f4977��6#   $ 1Q�63   5      5      �� 5   
      border_ContenedorFormulario#��[  5      $��283,168,282,84q�5      �� 5   
   $*��$Registro de Delegaciones Municipales��6   $��Center=�5      $��0,18,0,0q�5      $	��Top=�5         label_textoGrande#��[ 5!      �� 5#   
   $��Nombre o alias��6   $
��Left=�5$      $��300,222,0,0q�5%      $	��Top=�5&        label_textoPequeño#��[ 5'      �� 5)   
   $��
Dirección��6   $
��Left=�5*      $��300,340,0,0q�5+      $	��Top=�5,      #��[ 5-      �� 5/   
   $��	Municipio��6   $
��Left=�50      $��696,222,0,0q�51      $	��Top=�52      #��[ 53      �� 55   
   $��	Teléfono��6   $
��Left=�56      $��700,340,0,0q�57      $	��Top=�58      #��[ 59      �� 5;   
   $��Código postal��6   $
��Left=�5<      $��300,466,0,0q�5=      $	��Top=�5>      #��[ 5?      �� 5A   
   $��Correo electrónico��6   $
��Left=�5B      $��694,466,0,0q�5C      $	��Top=�5D      #��[ 5E      �� 5G   
   -   5        	 ��Name$	 	tb_nombre��5G      $
��Left=�5H      $��333,194,0,0q�5I      $	��Top=�5J      $	��270��5K      
 �� 	MaxLength$	
 250��5L        textBox_textBoxTransparente#��[ 5M      �� 5O   
   -   5        $	 tb_direccion��5O      $
��Left=�5P      $��333,312,0,0q�6-   $	��Top=�5Q      $	��270��5R      $	
 250��5S      #��[ 5T      �� 5V   
   -   5        $	 tb_telefono��5V      $
��Left=�5W      $��730,312,0,0q�5X      $	��Top=�5Y      $	��270��5Z      $
 10��5[      #��[ 5\      6G   �� 5^   
   -   5        $	 tb_codigoPostal��5^      $
��Left=�5_      $��333,438,0,0q�5`      $	��Top=�5a      $	��270��5b      $
 5��5c      #��[ 5d      6G   �� 5f   
   -   5        $	 	tb_correo��5f      $
��Left=�5g      $��730,438,0,0q�5h      $	��Top=�5i      $	��270��5j      $	
 250��5k      #��[ 5l      �� 5n   
   -   5         ��Name$ cb_municipio��5n      $��730,194,300,511q�5o      $��13(�5p      ��5q      �� *
municipios+.  (MahApps.Metro.IconPacks.PackIconMaterial  5s   
      Kind$ 	RenameBox=�6%   $��304,192,0,0q�5t   )   $��26��6>   $��20��6J     5v   
   $
 City=�6%   $��699,192,0,0q�5w   )   $��26��6>   $��20��6J     5y   
   $	 Map=�6%   $��304,312,0,0q�5z   )   $��26��6>   $��20��6J     5|   
   $ CellphoneBasic=�6%   $��700,312,0,0q�5}   )   $��24��6>   $��20��6J     5   
   $ Gmail=�6%   $��699,440,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $ Numeric=�6%   $��304,438,0,0q�5�   )   $��24��6>   $��20��6J   �� 5�   
   -   5         ��Name$ button_Registrar��5�      $0��*Registrar delegación 
          municipal��5�      $��Center=�5�      $��	0,556,0,0q�5�      $	��Top=�5�        button_botonMediano#��[ 5�      $��57��5�   0   �� 5�   
   -	   5        $ button_Regresar��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6     button_botonIcono#��[ 5�      $��	28,28,0,0q�5�   /   ��5�      /  )MahApps.Metro.IconPacks.MaterialExtension     Kind$ 	ArrowLeft=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 30Q�   Width$ 40Q�5�   /   �� 5�   
   -
   5        $ button_Chat��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	85,28,0,0q�5�   +   ��5�        $ Email=�$ 30Q�$ 40Q�5�   +   �� 5�   
   -   5        $ button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Logout=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_MinimizarVentana��5�      $
��Left=�5�      $��1188,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ WindowMinimize=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Close=�$ 30Q�$ 30Q�5�      �� 5�   
     border_lineasGrandes#��[ 6   $��700,470,300,258q�6?   �� 5�   
   #��[ 6   $��306,470,694,258q�6?   �� 5�   
   #��[ 6   $��700,344,300,384q�6?   �� 5�   
   #��[ 6   $��700,226,300,502q�6?   �� 5�   
   #��[ 6   $��304,344,696,384q�6?   �� 5�   
   #��[ 6   $��304,226,696,502q�6?   5�      5�      