   M S B A M L   `   `   `  ����B  >TabMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TabMenuTabMenu  5   	       TabMenu.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:TabMenu  5   	     � Title$  	Allergens��5   	   $	��864��5	      $
��1536��6'    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � WindowState$ 	Maximized=�6p    � WindowStyle$ ThreeDBorderWindow=�6�   .��5      �� 
�������.+�5   
   � .+�5      �� -   5        $��MySeparator��5      $��4��5      $	��150��5      $��Stretch=�5      $��Bottom=�5      
���   �5      5      � 5   
   $��97��6   $��
20,0,155,0q�6    � ColumnDefinitions 5      �� 5      $
��178* �6#   �� 5      $��3* �6#   .+�5      �� 
�������
������$��0,5,0,5q�6F   $��2��6`   $��-20,-8,-85.6,20q�6t   ._�5      ��  �� Orientation$ 
Horizontal=�6   $��0,-7.8,-77,0q�66    J� RenderTransformOrigin$ 0.5,0.5&�6L   $	��Top=�6l   $��80��6�   $��2��6�   z�5!      V� 5#      .~�5$      �� �� 5%      �� 5&       �� Angle$ -0.037Q�6.   T� 5'      5(      .+�5*      �� -   5        
	 J� Uid$	 0��5*      $	��130��6%   $��81��62   ���	#FF2196F3$��
0,0,100,-1q�6�   $��22(�6�   $	��Top=�6�   ��6>   Z� ��6T   Z� .��5+      �� $��75��6    $��58��6+   $��allergenic.png��67   $ 
0.51,0.162&�6O   5,      �� 5-      -   5        $	 1��5-      $	��276��6%   $��Medical Articles��62   $��48��6M   ���	#FF2196F3$��5,20,5,0q�6�   $��28(�6�   $ 0.5,0.5&�6�   #��� ��6�   $��Normal"�6$  $��MV Boli)�68  $��Stretch=�6M  $
��Left=�6p  $	��Top=�6�  ��6Y   Z� z�5.      V� 5/      .~�50   "   �� �� 51   "   �� 52   "   $ -0.037Q�62   T� 53   "   54      56      �� 57      -   5        $	 2��57      $	��275��6%   $
��Test��62   $��48��6A   ���	#FF2196F3$��28(�6�   $��5,20,5,0q�6�   $ 0.5,0.5&�6�   #��� ��6�   $��Normal"�6  $��MV Boli)�6+  $	��Top=�6@  ��6M   Z� z�58      V� 59      .~�5:   "   �� �� 5;   "   �� 5<   "   $ -0.037Q�62   T� 5=   "   5>      5@      �� 5A      -   5        $	 3��5A      $	��275��6%   $��	Callendar��63   $
��Auto��6G   ���	#FF2196F3$��28(�6�   $��	5,20,5,12q�6�   $ 0.5,0.5&�6�   #��� ��6�   $��Normal"�6!  $��MV Boli)�65  ��6U   Z� z�5B      V� 5C      .~�5D   "   �� �� 5E   "   �� 5F   "   $ -0.037Q�62   T� 5G   "   5H      5J      �� 5K      -   5        $	 4��5K      $	��281��6%   $��Prohibited Products��63   $��49��6Q   ���	#FF2196F3$��5,20,5,0q�6�   $��28(�6�   $ 0.5,0.5&�6�   #��� ��6�   $��Normal"�6)  $��MV Boli)�6=  $	��Top=�6R  $��0,4,8,4q�6j  ��6]   Z� z�5L      V� 5M      .~�5N   "   �� �� 5O   "   �� 5P   "   $ -0.037Q�62   T� 5Q   "   5R      5T      5V      5W      �� 5X      
�������
������$��5,5,5,0q�6F   $��105,-8,-155.6,-735q�6`   $��1��6|   ._�5Y      �� $ Vertical=�6   $��Right=�64   $��-91.8,0.2,5,359.4q�6P   $	��150��6k   $ 0.5,0.5&�6w   z�5[      V� 5\      .~�5]      �� �� 5^      �� 5_      $ -0.037Q�6.   T� 5`      5a      .+�5e      �� -   5        $��Right=�5e      $��
90,15,0,10q�6:   $��40��6e   $��55��6q   $ 0.5,0.5&�6|   
�������z�5f      V� 5g      .~�5h   "   �� �� 5i   "   �� 5j   "   $ -0.124Q�62   T� 5k   "   5l      ��5n      �� 5o      .��5q      �� $��21��6    $��25��6+   $��
logout.png��67   5r      �� 5s      -   5        $��Right=�5s      $��55��6P   $��40��6[   $ 0.511,0.859&�6g   
�������$��0,20,0,0q�6�   z�5t      V� 5u      .~�5v   "   �� �� 5w   "   
 �� AngleY$
 0.495Q�60   �� 5x   "   $ -0.536Q�62   T� 5y   "    T� X$ 0.117Q�65    T� Y$ 0.236Q�6?   5z      ��5|      �� 5}      .��5      �� $��21��6    $��30��6+   $��settings.png��67   5�      5�      5�      5�      � 5�   
   -	   5         �Name$ GridMain��5�      $	��750��6!   
������$��0,-20,74.6,0q�6F    5�      �� 5�      $
��220* �6#   �� 5�      $
��550* �6#   �� 5�      $
��523* �6#   �� 5�      $
��162* �6#   5�      5�      5�      