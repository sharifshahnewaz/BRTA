   M S B A M L   `   `   `  ����   Brta#    Brta.UserControls.ucEmergency   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    8data-http://schemas.microsoft.com/wpf/2008/toolkit  .��� $��5,0,5,0q�  � RowDefinitions  �� $
��auto ��� $��* ��� $
��auto �.+��� $��	Filter By��$��0��$��14(�$��3q�$��0,3,0,0q�.���   �� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto ��� $
��auto ��� $��* �.+��� $��0��$��0��$��0q�$��Group��$
��Left=�$��Center=��� $��0��$��1��$��0q�$��Category��$
��Left=�$��Center=��� -   $��cboGroup��$��1��$��0��$��5,5,5,5q�$	��150�� �� DisplayMemberPath$ No�� �� SelectedValuePath$ No���� -   $��cboCategory��$��1��$��1��$��5,5,5,5q�$	��150��$
 Name��$
 Name���� $��0��$��2��$��Manufacturer��$
��Left=�$��Center=��� -   $��cboManufacturer��$��1��$��2��$��5,5,5,5q�$	��150��$
 Name��$
 Name���� -   $��btnClear��$��2��$��3��$��Right=�$��30��$��Center=�����  �� Orientation$ 
Horizontal=�$��3q�.+��� $��23��$'��!/Brta;component/Images/Reload.ico���� $��5,0,5,0q�$��Center=�$��Center=�Clear)  #Microsoft.Windows.Controls.DataGrid  -   $��dtgItems��$��1��$��0,5,0,0q�   AutoGenerateColumns .     HeadersVisibility$ Column=�   Columns 3  -Microsoft.Windows.Controls.DataGridTextColumn  /  )Microsoft.Windows.Controls.DataGridColumn   Header$
 Name��	   
IsReadOnly	 . 
   Width8  2Microsoft.Windows.Controls.DataGridLengthConverter$

 auto 4  .Microsoft.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ 
Parts.Name�  $ Category��	 . $
 *  �� $ Parts.PartCategory.Name�  $ Manufacturer��	 . $
 *  �� $ Manufacturer.Name�  $ Price��	 . $
 *  �� $ Price�  $ Count��	 . $
 *  �� $ Count�  $ Minimum��	 . $
 *  �� $ Minimum��� $��0,0,0,0q�$��2��$��Right=�$��Center=�$ 
Horizontal=�.+��� -   $��btnClose��$��14(�$��0,5,0,5q�$	��100��$��40��$��Right=�$��Center=����� $ 
Horizontal=�$��3q�.+��� $��40��$%��/Brta;component/Images/exit.png���� $��5,0,5,0q�$��Center=�$��Center=�Exit