   M S B A M L   `   `   `  ����  Brta#    Brta.UserControls.ucEmergency   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      8data-http://schemas.microsoft.com/wpf/2008/toolkit  5      .��5      � $��5,0,5,0q�6     � RowDefinitions  5   
   �� 5      $
��auto �6   $	��144��6*   �� 5	      $��* �6   �� 5
      $
��auto �6   .+�5   
   �� $��	Filter By��6   $��0��6&   $��14(�63   $��3q�6A   $��0,3,0,0q�6M   .��5      �   5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$    � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $
��auto �6'   .+�5      �� $��0��6   $��0��6(   $��0q�65   $��Group��6@   $
��Left=�6P   $��Center=�6k   �� 5      $��0��6   $��2��6(   $��0q�65   $��Category��6@   $
��Left=�6S   $��Center=�6n   �� 5      -   5        $��cboGroup��5      $��1��6+   $��0��6;   $��5,5,5,5q�6H   $	��150��6Z    �� DisplayMemberPath$ No��6i    �� SelectedValuePath$ No��6�   6�   �� 5      -   5        $��cboCategory��5      $��1��6.   $��2��6>   $��5,5,5,5q�6K   $	��150��6]   $
 Name��6m   $
 Name��6�   6�   �� 5      $��0��6   $��3��6(   $��Manufacturer��65   $
��Left=�6L   $��Center=�6g   �� 5       -   5        $��cboManufacturer��5       $��1��62   $��3��6B   $��5,5,5,5q�6O   $	��150��6a   $
 Name��6p   $
 Name��6�   6�   5!      5"      )  #Microsoft.Windows.Controls.DataGrid  5$   
   -   5        $��dtgItems��5$      $��1��6(   $��0,10,0,0q�65      AutoGenerateColumns .     HeadersVisibility$ Column=�6d      Columns 5&      3  -Microsoft.Windows.Controls.DataGridTextColumn  5(      /  )Microsoft.Windows.Controls.DataGridColumn   Header$
 Name��6*      
IsReadOnly . 	   Width8  2Microsoft.Windows.Controls.DataGridLengthConverter$
	 auto 6p   4  .Microsoft.Windows.Controls.DataGridBoundColumn
   Binding
 68   ��  �� Path$ 
Parts.Name�6p     5)      $ Category��6*    . $	 * 6�   
 6<   �� $ Parts.PartCategory.Name�6�     5*      $ Manufacturer��6*    . $	 * 6~   
 6@   �� $ Manufacturer.Name�6~     5+      $ Price��6*    . $	 * 6l   
 69   �� $ Price�6l     5,      $ Count��6*    . $	 * 6l   
 69   �� $ Count�6l     5-      $ Minimum��6*    . $	 * 6p   
 6;   �� $ Minimum�6p   51      �� 53   
   $��0,0,0,0q�6   $��2��6&   $��Right=�63   $��Center=�6O    �� Orientation$ 
Horizontal=�6j   .+�54      �� -   5        $��btnClose��54      $��14(�6%   $��0,5,0,5q�63   $	��100��6D   $��40��6P   $��Right=�6\   $��Center=�6x   ��55      �� 56      $ 
Horizontal=�6!   $��3q�6:   .+�57      �� $��40��6!   $%��/Brta;component/Images/exit.png��6,   6W   �� 58      $��5,0,5,0q�6$   $��Center=�65   $��Center=�6R   Exit6s   59      5;      5<      5=      5>      