   M S B A M L   `   `   `  ����   Brta"    Brta.UserControls.ucDelivery   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    8data-http://schemas.microsoft.com/wpf/2008/toolkit  .��� $��5,0,5,0q�  � RowDefinitions  �� $
��auto ��� $
��auto ��� $��* ��� $
��auto ��� $
��auto �.+��� $��Details��$��0��$��14(�$��3q�$��0,3,0,0q�.���  � ColumnDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �  �� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��0��$��0q�$��Parts Name:��$
��Left=�$��Center=��� $��0��$��1��$��0q�$��	Category:��$
��Left=�$��Center=��� $��0��$��2��$��0q�$��Manufacturer:��$
��Left=�$��Center=��� -   $��txtPartName��$��1��$��0��$��5,0,0,0q�$
��Left=�$��Center=��� -   $��txtCategory��$��1��$��1��$��5,0,0,0q�$
��Left=�$��Center=��� -   $��txtManufacturer��$��1��$��2��$��5,0,0,0q�$
��Left=�$��Center=��� $��2��$��0��$��5,0,0,0q�$��Price:��$
��Left=�$��Center=��� $��2��$��1��$��5,0,0,0q�$��Count:��$
��Left=�$��Center=��� $��2��$��2��$��5,0,0,0q�$��Minimum:��$
��Left=�$��Center=��� -   $��txtPrice��$��3��$��0��$��5,0,0,0q�$
��Left=�$��Center=��� -   $��txtCount��$��3��$��1��$��5,0,0,0q�$
��Left=�$��Center=��� -   $��
txtMinimum��$��3��$��2��$��5,0,0,0q�$
��Left=�$��Center=��� $��Find Car��$��1��$��14(�$��3q�$��0,3,0,0q�.���   �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � �� $
��auto ��� $
��auto ��� $��* �.+��� $��0��$��0��$��0q�$��Group��$
��Left=�$��Center=��� $��0��$��2��$��0q�$��Model��$
��Left=�$��Center=��� -   $��cboGroup��$��1��$��0��$��5,5,5,5q�$	��150�� �� DisplayMemberPath$ No�� �� SelectedValuePath$ No���� -   $��cboModel��$��1��$��2��$��5,5,5,5q�$	��150��$
 Name��$
 Name���� $��0��$��3��$��Reg No��$
��Left=�$��Center=��� -	   $��txtRegNo��$��1��$��3��$��5,5,5,5q�$	��150��$
��Left=�$��Center=��� -
   $��btnClear��$��2��$��3��$��Right=�$��30��$��Center=�����  �� Orientation$ 
Horizontal=�$��3q�.+��� $��23��$'��!/Brta;component/Images/Reload.ico���� $��5,0,5,0q�$��Center=�$��Center=�Clear)  #Microsoft.Windows.Controls.DataGrid  -   $��dtgCars��$��2��$��0,10,0,0q�   AutoGenerateColumns .     HeadersVisibility$ Column=�   Columns 3  -Microsoft.Windows.Controls.DataGridTextColumn  /  )Microsoft.Windows.Controls.DataGridColumn   Header$	 Car��	   
IsReadOnly	 . 
   Width8  2Microsoft.Windows.Controls.DataGridLengthConverter$
 * 4  .Microsoft.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ RegNo�� $��3��$��0,5,0,5q� �� $
��auto ��� $��* �.+��� $��0��$��Comment��$
��Left=�$��Center=�$��14(��� -   $��
txtComment��$��1��$��5,0,0,0q�$
��Left=�$��Center=�$	��500���� $��0,0,0,0q�$��4��$��Right=�$��Center=�$ 
Horizontal=�.+��� -   $��btnAddToCar��$��14(�$��0,5,5,5q�$	��120��$��40��$��Right=�$��Center=����� $ 
Horizontal=�$��3q�.+��� $��40��$*��$/Brta;component/Images/tournevis.ico���� $��5,0,5,0q�$��Center=�$��Center=�
Add to car�� -   $��btnClose��$��14(�$��0,5,0,5q�$	��120��$��40��$��Right=�$��Center=����� $ 
Horizontal=�$��3q�.+��� $��40��$&�� /Brta;component/Images/close.ico���� $��5,0,5,0q�$��Center=�$��Center=�Close