   M S B A M L   `   `   `  ����   Brta    Brta.UserControls.ucCars   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    8data-http://schemas.microsoft.com/wpf/2008/toolkit  .��� $��5,0,5,0q�  � RowDefinitions  �� $
��auto ��� $��* ��� $
��auto �.+��� $��	Filter By��$��0��$��14(�$��3q�$��0,3,0,0q�.���   �� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto ��� $
��auto ��� $��* �.+��� $��0��$��0��$��0q�$��Group��$
��Left=�$��Center=��� -   $��cboGroup��$��1��$��0��$��5,5,5,5q�$	��250�� �� DisplayMemberPath$ No�� �� SelectedValuePath$ No���� $��0��$��1��$��0q�$��Model��$
��Left=�$��Center=��� -   $��cboModel��$��1��$��1��$��5,5,5,5q�$	��250��$
 Name��$
 Name���� $��0��$��2��$��0q�$��Reg No��$
��Left=�$��Center=��� -   $��txtRegNo��$��1��$��2��$��5,5,5,5q�$	��250��$
��Left=�$��Center=��� -   $��btnClear��$��3��$��0��$��Right=�$��30��$��Center=�����  �� Orientation$ 
Horizontal=�$��3q�.+��� $��23��$'��!/Brta;component/Images/Reload.ico���� $��5,0,5,0q�$��Center=�$��Center=�Clear)  #Microsoft.Windows.Controls.DataGrid  -   $��dtgCars��$��1��$��0,5,0,0q�   AutoGenerateColumns .     HeadersVisibility$ Column=�   Columns 3  -Microsoft.Windows.Controls.DataGridTextColumn  /  )Microsoft.Windows.Controls.DataGridColumn   Header$	 Car��	   
IsReadOnly	 . 
   Width8  2Microsoft.Windows.Controls.DataGridLengthConverter$
 * 4  .Microsoft.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ RegNo�  $ Model��	 . $
 *  �� $ CarModel.Name�  $ Group��	 . $
 *  �� $ CarModel.Group.No��� $��0,0,0,0q�$��2��$��Right=�$��Center=�$ 
Horizontal=�.+��� -   $��	btnAddCar��$��14(�$��0,5,5,5q�$	��130��$��40��$��Right=�$��Center=����� $ 
Horizontal=�$��3q�.+��� $��40��$*��$/Brta;component/Images/red-cross.ico���� $��5,0,5,0q�$��Center=�$��Center=�	Add Car�� -   $��btnEdit��$��14(�$��0,5,5,5q�$	��130��$��40��$��Right=�$��Center=����� $ 
Horizontal=�$��3q�.+��� $��40��$*��$/Brta;component/Images/Misc-Edit.ico���� $��5,0,5,0q�$��Center=�$��Center=�
Edit Car�� -   $��btnClose��$��14(�$��0,5,0,5q�$	��130��$��40��$��Right=�$��Center=����� $ 
Horizontal=�$��3q�.+��� $��40��$%��/Brta;component/Images/exit.png���� $��5,0,5,0q�$��Center=�$��Center=�Exit