   M S B A M L   `   `   `  ����>  :fyp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:fyp.Downloadsfyp.Downloads  5   	   +clr-namespace:fyp.Controlsfyp.Controls  5           fyp.Downloads.DownloadItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:fyp.Downloads     5   	   /controlsclr-namespace:fyp.Controls     5      -   5          � ContextMenu  5      �� 5   
   .@�5      m� -   5        $
��Open��5      5      m� 5      -   5        $��Show in folder��5      5      5       � 	Resources 5         ButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� CornerRadius �� Triggers	 P� Property
 P� Value �� 
TargetName ��Name  sb2 g� Duration g� 	BeginTime �� TargetProperty	 W� To  sb��%  &	      &	 �    &	 p    �� 5   
   " ��64   .�5      ��  �@�OverridesDefaultStyle . 67   �� 5       � ��$ 5q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��1q�5    !   $ 2q�5!   !   
������ $ 3��5#   !   
������ ._�5%      �� $��Center=�6/   $��Center=�6L   5'       5)      P� 5*      	 �@J�IsMouseOver
 . . �5+   "   �� $ border��6)    � ��
 ���� 6T   5,      5.      50      51      �� 53   
   $	 sb2��6!   .��54      W� $ 
00:00:0.10D�6"   $ 0:0:0:0X�68   $ Opacity�6L   $ 1X�6p   55      �� 56      $ sb��6$   .��57      W� $ 
00:00:0.10D�6"   $ 0:0:0:0X�68   $ Opacity�6L   $ 0X�6p   58      5:      .��5;      �� ���	#FFE2E2E2$��0,0,0,1q�6%   $��Stretch=�6?   $��Stretch=�6^   ._�5<   
   � -   5         �Name$ bg��5<      
�������.+�5=      � -   5        $��Stretch=�5=   :   $��Stretch=�6V   $��0,0,35,0q�6t   .+�5?      �� -   5         ��Name$ FileName��5?      $��	File name��6.   $��17.333(�6?   $��	10,6,0,33q�6Q   �� 5@      -   5        $
 Size��5@      $��
10,29,0,15q�6*   $��MB��6>   6K   5B         fyp.Controls.IconButton  5C      -   5          Name$ button��5C   "      fyp.Controls.IconButton   PreviewMouseDown$ button_Click��6�   $��Right=�62   $	��Top=�6N   $��20��6f   $��20��6q   $��0,9,10,0q�6�   ��6}   Z� ��6�   Z� 6�   � 5D      -	   5        $ ProgressBar��5D      $��Bottom=�6(   $
��Left=�6C   $��5��6^   ���#1abc9c$��0,0,0,-1q�6~   5E      5G      5J      