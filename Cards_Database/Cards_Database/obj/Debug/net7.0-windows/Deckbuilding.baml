   M S B A M L   `   `   `  ����I  ECards_Database, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Cards_DatabaseCards_Database  5      !    Cards_Database.Deckbuilding   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Cards_Database     5        N� Title$  Deckbuilding��5	      .��5      �� .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,    � ColumnDefinitions 5      �� 5      6!   .+�5       �� -   5         ��Name$ Navbar��5       $��0��6)   $��0��66   $��3��6F    �� Orientation$ 
Horizontal=�6Z   .+�5!      �� -   5        $��New Card��5!      $��5q�6,   6P   �� 5"      $��
Build deck��6   $��5q�6.   6<   �� 5$      -   5         ��Name$ homeBtn��5$      $��5q�6*   $��25��65   $��Center=�6@   ��5(      �� 5)       �� 
TargetType" ��6*   .R�5*      ��  ��Name$ HomeBtn��6$   $��/homeBtn.png��65    �� Triggers 5+      P� 5,   "   	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��6A   . �5-   &   ��  �� 
TargetName$ HomeBtn��6-    �� Property �@J�Opacity �� Value$	 0.5Q�6U   5.   #   50      54      55       � 57      -   5          �Name$ 	MainFrame��57      $��1��6'     � NavigationUIVisibility$ Hidden=�64   6V   �� 59      $��1��6   $��0��6&   .+�5:      �� $
��Auto��6   $��Center=�6%   $��18(�6B   
Deck Name:6\   �� 5;      -   5         ��Name$ DeckNameInput��5;      $��Center=�6-   $	��400��6J   6X   �� 5<      $
��Auto��6   $��Center=�6%   $��18(�6B   	Format:6Y   �� 5=      -   5         ��Name$ DeckFormatInput��5=      $	��400��61   .@�5>      �� .��6   
Standard6)   �� 5?      .��6   Pauper6'   �� 5@      .��6   Paupermander6-   �� 5A      .��6   Modern6'   �� 5B      .��6   	Pioneer6(   �� 5C      .��6   	Commander6*   5D      �� 5E      $
��Auto��6   $��Center=�6)   $��18(�6F   Your cards:6a   &   System.Windows.Controls.DataGrid  5F      -   5          Name$ DataGrid��5F   5   $	��400��6   $	��250��6'   $��Center=�6G      AutoGenerateColumns$ False��6k      CanUserAddRows$ False��6�      Columns 5G      0  *System.Windows.Controls.DataGridTextColumn  5H      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Card Name��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *
CardName+6j     5I      $ 
Mana Value��6-   $ * 6`    6A   �� *	ManaValue+6l     5J      $ Quantity��6-   $ * 6`    6?   �� *CardQuantity+6l   5N      5O      �� 5Q   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5R      �� -   5        $ DataCardName��5R   .   $	��250��6   $��20��6"   6G   �� 5S      -	   5        $ 	CardValue��5S   1   $��35��6   $��20��6%   6k   �� 5T      -
   5        $ CardQtd��5T      $��20��6,   $��Center=�68   .@�5U      �� .��6#   16&   �� 5V      .��6#   26&   �� 5W      .��6#   36&   �� 5X      .��6#   46&   5Y      �� 5Z      -   5        $ 
AddCardBtn��5Z      $��7,1,1,1q�6-   $��35��6>   $��28��6I   $��Center=�6n   ��5[      �� 5\      " ��6*   .R�5]      �� $ Image��6$   $��/AddBtn.png��63    5^      P� 5_   "   	 �@J�IsMouseOver$

 True��6A   . �5`   &   �� $ Image��6-    �@J�Opacity$	 0.5Q�6S   5a   #   5c      5e      �� 5g      -   5        $ DeleteCardBtn��5g      $��7,1,1,1q�61   $��35��6B   $��28��6M   $��Center=�6[   ��5h      �� 5i      " ��6*   .R�5j      �� $ Image��6$   $��/DeleteBtn.png��63    5k      P� 5l   "   	 �@J�IsMouseOver$

 True��6A   . �5m   &   �� $ Image��6-    �@J�Opacity$	 0.5Q�6S   5n   #   5p      5s      5x      �� 5z   
   $ 
Horizontal=�6   $��Center=�60   $��5��6M   .+�5|      �� -   5        $��	-8,1,12,1q�5|      $��15(�6,   .��6P   Export to .txt6`   �� 5~      -   5        $ excelBtn��5~      $��1,1,1,1q�6+   $��15(�6<   .��6b   Export to Excel6s   5      5�      5�      5�      