   M S B A M L   `   `   `  ����Q  MRutas-Senderismo-Hito2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Rutas_Senderismo_Hito2Rutas_Senderismo_Hito2  5   	   '    !Rutas_Senderismo_Hito2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Rutas_Senderismo_Hito2     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6$    � 
ResizeMode$ NoResize=�60   .��5	      � -   5         �Name$ Diseño��5	       � RowDefinitions 5
   
   �� 5      $
��100* �6   �� 5      $	��70* �6   �� 5      $	��40* �6   �� 5      $��40 �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��70* �6   �� 5      $	��40* �6   �� 5      $	��40* �6    � ColumnDefinitions 5   
   �� 5      $
��179* �6   �� 5      $	��66* �6   �� 5      $
��144* �6   �� 5      $
��144* �6   �� 5      $	��66* �6   �� 5      $
��179* �6   .+�5   
   �� -   5         ��Name$ FondoVentana��5      $
��Left=�6*   $	��434��6E   $��9��6R   
���   �$	��Top=�6r   $	��800��6�   $��6��6�    � IsSharedSizeScope . ��5      �� 5        �� ImageSource$ /Imagenes/fondo login.jpg��6   5"      �� 5$   
   -   5        $ 
FondoLogin��5$      $��1��6(   $��4��68   $��Center=�6L   $	��252��6i   $��1��6v   $��Center=�6�   $	��412��6�    J� RenderTransformOrigin$ 0.499,0.509&�6�   $��6��6�   ���	#FFDEDEDE	 J� Opacity$		 0.7Q�6�   
 �� RadiusX$
 10��6�    �� RadiusY$ 10��6  �� 5%   
   -   5         ��Name$ 
txtUsuario��5%      $��2��6&   $��2��66   $��Center=�6J   $��3��6g    �� TextWrapping$
 Wrap=�6t   $��Center=�6�   $	��276��6�   $��36��6�   �� 5'   
   -   5        $ txtContraseña��5'      $��2��6)   $��2��69   $��Center=�6M   $��5��6j   $
 Wrap=�6w   $��Center=�6�   $	��276��6�   $��36��6�   $y�Hidden=�6�   �� 5)   
   -   5         ��Name$ lblLoginTitulo��5)      $��2��6(   $��Iniciar Sesión��68   $
��Left=�6Q   $��	10,20,0,0q�6l   $��1��6   $	��Top=�6�   $��42��6�   $	��138��6�   $��20(�6�   �� 5*   
   -   5        $ 
lblUsuario��5*      $��2��6$   $��Usuario��64   $
��Left=�6F   $��2��6a   $	��Top=�6n   $��0,7,0,0q�6�   $��14(�6�   �� 5+   
   -   5        $ lblContraseña��5+      $��2��6'   $��Contraseña��67   $
��Left=�6L   $��4��6g   $	��Top=�6t   $��14(�6�   $��90��6�   $��0,7,0,0q�6�   $��2��6�   �� 5,   
   -	   5         ��Name$ btnLogin��5,      $��3��6#   $��Entrar��63   $��Center=�6D   $��6��6a   $��Center=�6n   $��32��6�   $	��128��6�   $��14(�6�   6�   G� 5.   
   -
   5         G�Name$ ContraseñaBox��5.      $��2��6-   $��Center=�6=   $��5��6Z   $��Center=�6g   $	��276��6�   $��36��6�   $��2��6�   �� 5/   
   -   5         ��Name$ CheckBoxContraseña��5/      $��2��6/   $��Visualizar contraseña��6?   $
��Left=�6_   $��10,5,0,0q�6z   $��6��6�   $	��Top=�6�   $��26��6�   $	��123��6�   $��10(�6�   6�   �� 50   
   -   5        $ lbl_incorrectocampos��50      $��2��6.   $'��!Usuario o contraseña incorrectos��6>   $
��Left=�6i   $��
102,10,0,0q�6�   $��2��6�   $	��Top=�6�   $��31��6�   $	��228��6�   $��2��6�   $��11(�6�   $
��Bold"�6�   ���	#FFFD0606$��3��6  52      53      