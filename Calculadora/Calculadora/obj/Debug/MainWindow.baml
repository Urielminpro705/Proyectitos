   M S B A M L   `   `   `  ����F  BCalculadora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CalculadoraCalculadora  5   	       Calculadora.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Calculadora     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��300��6)   $	��300��65   $	��450��6D   
�������.��5	      � ��5
   
   �� 5       �� ImageSource$ /Imagen15.png��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��2q�6   
�������$��4��69   $��0��6M   $��5q�6]   
�������._�5      �� -   5        $��
pantallita��5      $��Center=�6*   $��Center=�6E   $��17(�6b   $
��Bold"�6p   6�   5      � 5   
   $��0��6   $��1��6    5      �� 5      $��* �6    �� 5       $��* �6    �� 5!      $��* �6    �� 5"      $��* �6    �� 5#      $��* �6    .+�5'      �� -   5        $��0q�5'   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��0��6s   ��5(      �� 5)      $ /Imagen10.png��6!   .��5*   %   CE5+      �� 5-      -   5        $��0q�5-   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��1��6s   ��5.      �� 5/      $ /Imagen11.png��6!   .��50   %   751      �� 52      -   5        $��0q�52   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��2��6s   ��53      �� 54      $ /Imagen11.png��6!   .��55   %   456      �� 57      -   5        $��0q�57   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��3��6s   ��58      �� 59      $ /Imagen11.png��6!   .��5:   %   15;      �� 5<      -   5        $��0q�5<   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��4��6s   ��5=      �� 5>      $ /Imagen11.png��6!   .��5?   %   +/-5@      5D      � 5F   
   $��1��6   $��1��6    5G      �� 5H      $��* �6    �� 5I      $��* �6    �� 5J      $��* �6    �� 5K      $��* �6    �� 5L      $��* �6    .+�5P      �� -   5        $��0q�5P   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��1��6s   ��5Q      �� 5R      $ /Imagen11.png��6!   .��5S   %   85T      �� 5U      -   5        $��0q�5U   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��2��6s   ��5V      �� 5W      $ /Imagen11.png��6!   .��5X   %   55Y      �� 5Z      -	   5        $��0q�5Z   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��3��6s   ��5[      �� 5\      $ /Imagen11.png��6!   .��5]   %   25^      �� 5_      -
   5        $��0q�5_   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��4��6s   ��5`      �� 5a      $ /Imagen11.png��6!   .��5b   %   05c      5f      � 5h   
   $��2��6   $��1��6    5i      �� 5j      $��* �6    �� 5k      $��* �6    �� 5l      $��* �6    �� 5m      $��* �6    �� 5n      $��* �6    .+�5r      �� -   5        $��0q�5r   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��1��6s   ��5s      �� 5t      $ /Imagen11.png��6!   .��5u   %   95v      �� 5w      -   5        $��0q�5w   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��2��6s   ��5x      �� 5y      $ /Imagen11.png��6!   .��5z   %   65{      �� 5|      -   5        $��0q�5|   $   $��0q�68   $��20(�6C   $
��Bold"�6Q   $��0��6c   $��3��6s   ��5}      �� 5~      $ /Imagen11.png��6!   .��5   %   35�      �� 5�      -   5        $��0q�5�   #   $��0q�67   $��20(�6B   $
��Bold"�6P   $��0��6b   $��4��6r   ��5�      �� 5�      $ /Imagen11.png��6!   .��5�   %   .5�      5�      � 5�   
   $��3��6   $��1��6    5�      �� 5�      $��* �6    �� 5�      $��* �6    �� 5�      $��* �6    �� 5�      $��* �6    �� 5�      $��* �6    .+�5�      �� -   5        $��0q�5�   "   $��0q�66   $��20(�6A   $
��Bold"�6O   $��0��6a   $��0��6q   ��5�      �� 5�      $ /Imagen11.png��6!   .��5�   %   +5�      �� 5�      -   5        $��0q�5�   #   $��0q�67   $��20(�6B   $
��Bold"�6P   $��0��6b   $��1��6r   ��5�      �� 5�      $ /Imagen11.png��6!   .��5�   %   -5�      �� 5�      -   5        $��0q�5�   ,   $��0q�6@   $��20(�6K   $
��Bold"�6Y   $��0��6k   $��2��6{   ��5�      �� 5�      $ /Imagen11.png��6!   .��5�   %   X5�      �� 5�      -   5        $��0q�5�   &   $��0q�6:   $��20(�6E   $
��Bold"�6S   $��0��6e   $��3��6u   ��5�      �� 5�      $ /Imagen11.png��6!   .��5�   %   /5�      �� 5�      -   5        $��0q�5�   '   $��0q�6;   $��20(�6F   $
��Bold"�6T   $��0��6f   $��4��6v   ��5�      �� 5�      $ /Imagen12.png��6!   .��5�   %   =5�      5�      5�      5�      