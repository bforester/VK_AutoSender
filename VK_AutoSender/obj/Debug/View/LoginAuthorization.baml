   M S B A M L   `   `   `  ����H  DVK_AutoSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:VK_AutoSender.ViewVK_AutoSender.View  5   	   +    %VK_AutoSender.View.LoginAuthorization   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ,local clr-namespace:VK_AutoSender.View  5   	   -   5          �Name$  	AuthLogin��5   	    � Icon$ ../Resources/icon.ico��5	   	    � Title$ Sign in Login��5   	   $	��450��6   $	��300��6,    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�5   	   
�������.��5      ��  �� Orientation$ Vertical=�6   $��Center=�6(   $��0, 70, 0, 0q�6E    � Cursor$  ��6Z   .+�5   
   �� $
��Wrap=�6   $��Login��6(   $��Center=�65   $��20(�6R   �� 5   
   -   5         ��Name$ login_TextBox��5      $��Center=�6)    �� TextWrapping$
 Wrap=�6F   $��Center=�6Z   $	��203��6u   $��34��6�   $��Center=�6�   $��20(�6�   �� 5   
   $
��Wrap=�6   $��Password��6(   $��Center=�68   $��20(�6U   G� 5   
   -   5        	 G�Name$	 password_TextBox��5      $��Center=�60   $��Center=�6M   $	��203��6h   $��34��6t   $��Center=�6�   $��10(�6�   �� 5   
   $
��Wrap=�6   $��Application ID��6(   $��Center=�6>   $��20(�6[   �� 5   
   -   5        $ AppID_TextBox��5      $��Center=�6)   $
 Wrap=�6F   $��Center=�6Z   $	��203��6u   $��34��6�   $��Center=�6�   $��20(�6�   �� 5   
   -   5        $��Sign in��5      $��34��6#   $��15(�6/   $��0, 30, 0, 0q�6=   ���	#FF5B94CC6i   �� 5   
   -   5        $��Sign in use token��5      $��34��6-   $��15(�69   $��0, 30, 0, 0q�6G   ���	#FF44DEAA6s   5      5      