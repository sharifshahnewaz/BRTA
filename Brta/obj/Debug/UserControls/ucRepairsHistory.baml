   M S B A M L   `   `   `  ����  Brta(    "Brta.UserControls.ucRepairsHistory   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      8data-http://schemas.microsoft.com/wpf/2008/toolkit  5      .��5      � $��5,0,5,0q�6     � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5	      $��* �6   �� 5
      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��
Filter Car��6   $��0��6'   $��14(�64   $��3q�6B   $��0,3,0,0q�6N   .��5      �   5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$    � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $��* �6'   �� 5      $
��auto �6'   �� 5      $��* �6'   .+�5      �� $��0��6   $��0��6(   $��0q�65   $��Group��6@   $
��Left=�6P   $��Center=�6k   �� 5      -   5        $��cboGroup��5      $��1��6+   $��0��6;   $��5,5,5,5q�6H   $	��160��6Z    �� DisplayMemberPath$ No��6i    �� SelectedValuePath$ No��6�   $
��Left=�6�   $��Center=�6�   6�   �� 5      $��0��6   $��1��6(   $��0q�65   $��Model��6@   $
��Left=�6P   $��Center=�6k   �� 5      -   5        $��cboModel��5      $��1��6+   $��1��6;   $��5,5,5,5q�6H   $	��160��6Z   $
 Name��6i   $
 Name��6�   $
��Left=�6�   $��Center=�6�   6�   �� 5       $��0��6   $��2��6(   $��Reg No��65   $
��Left=�6F   $��Center=�6a   �� 5!      -   5        $��txtRegNo��5!      $��1��6*   $��2��6:   $��5,5,5,5q�6G   $	��150��6Y   $
��Left=�6h   $��Center=�6�   6�   �� 5"      $��2��6   $��0��6(   $��Repaired By��65   $
��Left=�6K   $��Center=�6f   �� 5#      -   5        $��cboRepairedBy��5#      $��3��60   $��0��6@   $��5,5,5,5q�6M   $	��160��6_   $ UserId��6n   $ UserId��6�   $
��Left=�6�   $��Center=�6�   6�   �� 5$      $��2��6   $��1��6(   $��	From Date��65   $
��Left=�6I   $��Center=�6d   +  %Microsoft.Windows.Controls.DatePicker  5%      -   5        $��dtpFromDate��5%   "   $
��Left=�65   $��Center=�6P   $��3��6k   $��1��6{   $��5,5,5,0q�6�   $��30��6�   $	��160��6�   6�   �� 5&      $��2��6   $��2��6(   $��To Date��65   $
��Left=�6G   $��Center=�6b     5'      -   5        $��	dtpToDate��5'   "   $
��Left=�63   $��Center=�6N   $��3��6i   $��2��6y   $��5,5,5,0q�6�   $��30��6�   $	��160��6�   6�   �� 5(      -   5        $��btnClear��5(   6   $��3��6   $��2��6)   $��Right=�6F   $��30��6b   $��Center=�6n   ��5)      �� 5*       �� Orientation$ 
Horizontal=�6%   $��3q�6>   .+�5+      �� $��23��6%   $'��!/Brta;component/Images/Reload.ico��61   6^   �� 5,      $��5,0,5,0q�6(   $��Center=�69   $��Center=�6V   Clear6x   5-      5/      50      51      )  #Microsoft.Windows.Controls.DataGrid  53   
   -   5        $��
dtgHistory��53      $��1��6*   $��0,10,0,0q�67      AutoGenerateColumns .     HeadersVisibility$ Column=�6f      Columns 55      3  -Microsoft.Windows.Controls.DataGridTextColumn  56      /  )Microsoft.Windows.Controls.DataGridColumn   Header$	 Car��6*   	   
IsReadOnly	 . 
   Width8  2Microsoft.Windows.Controls.DataGridLengthConverter$

 auto 6o   4  .Microsoft.Windows.Controls.DataGridBoundColumn   Binding 67   ��  �� Path$ 	Car.RegNo�6o     57      $ Model��6*   	 . $
 * 6x    69   �� $ Car.CarModel.Name�6x     58      $ Parts��6*   	 . $

 auto 6}    69   �� $ PartsDetail.Parts.Name�6}     59      $ Manufacturer��6*   	 . $
 * 6�    6@   �� $# PartsDetail.Manufacturer.Name�6�     5:      $ Repaired By��6*   	 . $
 * 6|    6?   �� $ RepairedBy.Name�6|     5;      $ Repaired Time��6*   	 . $

 auto 6|    6A   �� $ RepairedTime�6|   5=      �� 5@   
   $��0,0,0,0q�6   $��3��6&   $��Right=�63   $��Center=�6O   $ 
Horizontal=�6j   .+�5B      �� -	   5        $��btnClose��5B      $��14(�6%   $��0,5,0,5q�63   $	��100��6D   $��40��6P   $��Right=�6\   $��Center=�6x   ��5C      �� 5D      $ 
Horizontal=�6!   $��3q�6:   .+�5E      �� $��40��6!   $%��/Brta;component/Images/exit.png��6,   6W   �� 5F      $��5,0,5,0q�6$   $��Center=�65   $��Center=�6R   Exit6s   5G      5I      5J      5L      5M      