   M S B A M L   `   `   `  ����K  GDireccionGeneral, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SGRV.GUIDireccionGeneralSGRV.GUIDireccionGeneral  5   	   /    )SGRV.GUIDireccionGeneral.RegistrarUsuario   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SGRV.GUIDireccionGeneral     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  RegistrarUsuario��5	   	   $	��730��5
   	   $
��1300��6    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��381* �6   �� 5      $
��349* �6   .+�5   
   ��  �� CornerRadius$ 25��6   $��2��6#    J� RenderTransformOrigin$ 0.513,0.427&�64   ��5      �� 5      .��5      �  � Color$ #006a65��6#   	 � Offset$		 0.0Q�63   � 5      $ #3f4977��6#   $	 1Q�63   5      5      �� 5   
      border_ContenedorFormulario#��[  6   $��296,170,296,92q�6F   $��2��6^   �� 5   
     border_lineasGrandes#��[ 6   $��331,244,669,135q�6?   �� 5    
   #��[ 6   $��686,360,314,19q�6?   �� 5!   
   #��[ 6   $��331,360,669,19q�6?   �� 5"   
   #��[ 6   $��686,99,314,248q�6?   $��1��6W   �� 5$   
   $��Registro de Usuarios��6   $��Center=�5%      $��0,18,0,0q�5&      $	��Top=�5'        label_textoGrande#��[ 5(      �� 5*   
   $��Nombre de usuario��6   $
��Left=�5+      $��325,244,0,0q�5,      $	��Top=�5-        label_textoPequeño#��[ 5.      �� 50   
   $��Contraseña��6   $
��Left=�51      $��680,360,0,0q�52      $	��Top=�53      #��[ 54      $��2��6<   �� 56   
   $��Cargo��6   $
��Left=�57      $��675,244,0,0q�58      $	��Top=�59      #��[ 5:      $ 
0.23,0.578&�6<   �� 5<   
   $��Delegación��6   $
��Left=�5=      $��
325,99,0,0q�5>      $	��Top=�5?      #��[ 5@      $��1��6<   �� 5B   
   $��Confirmar contraseña��6   $
��Left=�5C      $��
680,99,0,0q�5D      $	��Top=�5E      #��[ 5F      $��1��6<   �� 5H   
   $��Correo��6   $
��Left=�5I      $��326,360,0,0q�5J      $	��Top=�5K      #��[ 5L      $��2��6<   �� 5N   
   -   5        
 ��Name$
 tb_username��5N      $
��Left=�5O      $��368,212,0,0q�5P       �� TextWrapping$
 Wrap=�5Q      $	��Top=�5R      $	��263��5S       �� 	MaxLength$	 250��5T        textBox_textBoxTransparente#��[ 5U      �� 5W   
   -   5        $
 	tb_correo��5W      $
��Left=�5X      $��365,330,0,0q�5Y      $	��Top=�5Z      $	��264��5[      $	 250��5\      #��[ 5]      G� 5_   
   -   5         G�Name$ pb_password��5_      $
��Left=�5`      $��724,328,0,0q�5a      $	��Top=�5b      $	��262��5c       G� 	MaxLength$	 250��5d       ' #passwordBox_passwordBoxTransparente#��[ 5e      G� 5g   
   -   5        $ pb_confirmarPassword��5g      $
��Left=�5h      $��
724,67,0,0q�5i      $	��Top=�5j      $	��262��5k      $	 250��5l      #��[ 5m      $��1��6S   �� 5o   
   -   5         ��Name$ cb_cargo��5o      $
��Left=�5p      $��724,214,0,0q�5q      $	��Top=�5r      $��13(�5s      $	��256��5u      $��26��6   ��5t      �� *cargos+5u      �� 5w   
   -   5        $ cb_delegacion��5w      $
��Left=�5x      $��
368,67,0,0q�5y      $��13(�5z      $	��Top=�5{      $	��263��5|      $��28��6   $��1��6+   �� 5~   
   -   5         ��Name$ button_Registrar��5~      $��Registrar usuario��5      $��Center=�5�      $��	0,175,0,0q�5�      $	��Top=�5�        button_botonMediano#��[ 5�      $��1��5�   0   �� 5�   
   -	   5        $ button_Regresar��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6     button_botonIcono#��[ 5�      $��	28,28,0,0q�5�   /   ��5�      /  )MahApps.Metro.IconPacks.MaterialExtension     Kind$ 	ArrowLeft=�3  -MahApps.Metro.IconPacks.BasePackIconExtension   Height$ 30Q�   Width$ 40Q�5�   /   �� 5�   
   -
   5        $ button_Chat��5�      $
��Left=�5�      $	��Top=�5�      $��44��5�      $��52��6   #��[ 5�      $��	85,28,0,0q�5�   +   ��5�        $ Email=�$ 30Q�$ 40Q�5�   +   �� 5�   
   -   5        $ button_CerrarSesion��5�      $
��Left=�5�      $��1140,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Logout=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_MinimizarVentana��5�      $
��Left=�5�      $��1188,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ WindowMinimize=�$ 30Q�$ 30Q�5�      �� 5�   
   -   5        $ button_CerrarVentana��5�      $
��Left=�5�      $��1234,28,0,0q�5�      $��44��5�      $��42��6   $	��Top=�5�      #��[ 5�      ��5�        $ Close=�$ 30Q�$ 30Q�5�      �� 5�   
   #��[ 6   $��331,99,669,248q�6?   $��1��6W   �� 5�   
   #��[ 6   $��680,244,320,135q�6?   .  (MahApps.Metro.IconPacks.PackIconMaterial  5�   
      Kind$ 	Briefcase=�6%   $��684,214,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $ FormTextboxPassword=�6%   $��
687,67,0,0q�5�   )   $��24��6=   $��20��6I   $��1��6T     5�   
   $ Gmail=�6%   $��331,330,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $ FormTextboxPassword=�6%   $��687,328,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $ Account=�6%   $��335,212,0,0q�5�   )   $��24��6>   $��20��6J     5�   
   $
 City=�6%   $��
335,67,0,0q�5�   )   $��24��6=   $��20��6I   $��1��6T   5�      5�      