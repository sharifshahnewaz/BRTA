   M S B A M L   `   `   `  ����   Brta(    "Brta.UserControls.ucRepairsHistory   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    8data-http://schemas.microsoft.com/wpf/2008/toolkit  .��� $��5,0,5,0q�  � RowDefinitions  �� $
��auto ��� $��* ��� $
��auto ��� $
��auto �.+��� $��
Filter Car��$��0��$��14(�$��3q�$��0,3,0,0q�.���   �� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto ��� $��* ��� $
��auto ��� $��* �.+��� $��0��$��0��$��0q�$��Group��$
��Left=�$��Center=��� -   $��cboGroup��$��1��$��0��$��5,5,5,5q�$	��160�� �� DisplayMemberPath$ No�� �� SelectedValuePath$ No��$
��Left=�$��Center=��� $��0��$��1��$��0q�$��Model��$
��Left=�$��Center=��� -   $��cboModel��$��1��$��1��$��5,5,5,5q�$	��160��$
 Name��$
 Name��$
��Left=�$��Center=��� $��0��$��2��$��Reg No��$
��Left=�$��Center=��� -   $��txtRegNo��$��1��$��2��$��5,5,5,5q�$	��150��$
��Left=�$��Center=��� $��2��$��0��$��Repaired By��$
��Left=�$��Center=��� -   $��cboRepairedBy��$��3��$��0��$��5,5,5,5q�$	��160��$ UserId��$ UserId��$
��Left=�$��Center=��� $��2��$��1��$��	From Date��$
��Left=�$��Center=�+  %Microsoft.Windows.Controls.DatePicker  -   $��dtpFromDate��$
��Left=�$��Center=�$��3��$��1��$��5,5,5,0q�$��30��$	��160���� $��2��$��2��$��To Date��$
��Left=�$��Center=�  -   $��	dtpToDate��$
��Left=�$��Center=�$��3��$��2��$��5,5,5,0q�$��30��$	��160���� -   $��btnClear��$��3��$��2��$��Right=�$��30��$��Center=�����  �� Orientation$ 
Horizontal=�$��3q�.+��� $��23��$'��!/Brta;component/Images/Reload.ico���� $��5,0,5,0q�$��Center=�$��Center=�Clear)  #Microsoft.Windows.Controls.DataGrid  -   $��
dtgHistory��$��1��$��0,5,0,0q�   AutoGenerateColumns .     HeadersVisibility$ Column=�   Columns 3  -Microsoft.Windows.Controls.DataGridTextColumn  /  )Microsoft.Windows.Controls.DataGridColumn   Header$	 Car��	   
IsReadOnly	 . 
   Width8  2Microsoft.Windows.Controls.DataGridLengthConverter$

 auto 4  .Microsoft.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ 	Car.RegNo�  $ Model��	 . $
 *  �� $ Car.CarModel.Name�  $ Parts��	 . $

 auto  �� $ PartsDetail.Parts.Name�  $ Manufacturer��	 . $
 *  �� $# PartsDetail.Manufacturer.Name�  $ Repaired By��	 . $
 *  �� $ RepairedBy.Name�  $ Repaired Time��	 . $

 auto  �� $ RepairedTime��� $��0,0,0,0q�$��3��$��Right=�$��Center=�$ 
Horizontal=�.+��� -	   $��btnClose��$��14(�$��0,5,0,5q�$	��100��$��40��$��Right=�$��Center=����� $ 
Horizontal=�$��3q�.+��� $��40��$%��/Brta;component/Images/exit.png���� $��5,0,5,0q�$��Center=�$��Center=�Exit