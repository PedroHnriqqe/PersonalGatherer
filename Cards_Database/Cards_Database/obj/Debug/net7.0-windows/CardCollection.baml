   M S B A M L   `   `   `  ����I  ECards_Database, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Cards_DatabaseCards_Database  5      #    Cards_Database.CardCollection   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Cards_Database     5        N� Title$  CardCollection��5	       � 	Resources 5      .   (Cards_Database.ByteArrayToImageConverter   ByteArrayToImageConverter��%   &	          5   
   6*   5      .��5      �� .��5   
   �  � ColumnDefinitions 5      �� 5      6%    � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      6"   .+�5        � -   5          �Name$ 	MainFrame��5       $��1��6'     � NavigationUIVisibility$ Hidden=�64   5"      �� 5&      $��0��6   $��0��6&   $��3��66    �� Orientation$ 
Horizontal=�6J   .+�5'      �� -   5        $��New Card��5'      $��5q�6,   6P   �� 5(      -   5        $��
Build deck��5(      $��5q�6.   6V   �� 5)      -   5         ��Name$ 
refreshBtn��5)      $��5q�6-   $��25��68   $��Center=�6C   ��5*      �� 5+       �� 
TargetType" ��6*   .R�5,      �� 	 ��Name$	 
RefreshBtn��6$   $��/RefreshBtn.png��68   
 �� Triggers
 5-      P� 5.   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5/   &   ��  �� 
TargetName$ 
RefreshBtn��6-    �� Property �@J�Opacity �� Value$	 0.5Q�6X   50   #   52      54      �� 55      -   5        $ homeBtn��55      $��5q�6*   $��25��65   $��Center=�6@   ��59      �� 5:      " ��6*   .R�5;      �� $	 HomeBtn��6$   $��/homeBtn.png��65   
 5<      P� 5=   "    �@J�IsMouseOver$
 True��6A   . �5>   &   �� $ HomeBtn��6-    �@J�Opacity$	 0.5Q�6U   5?   #   5A      5D      5E      �� 5H      -   5         ��Name$ 	CardPanel��5H      $��1��6.   ��5I      �� 5J      .R�5K      A�  A� Columns$ 4��6&    K� IsItemsHost$
 True��62   5L      ��5N      �� 5O      .R�5P      �� .+�5Q      �� ��6$   �� *	CardImg+ �� 	Converter# [  5R      5S      5U      5Y      5[      5]      