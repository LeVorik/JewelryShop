   M S B A M L   `   `   `  ����F  BJewelryShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:JewelryShop.PagesJewelryShop.Pages  5      $    JewelryShop.Pages.CustomerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:JewelryShop.Pages     5      $	��450��5      $	��800��6     N� Title$  Покупатели��5      .��5
      ]� $��10q�6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $��0,0,0,10q�6C   .+�5      �� -   5         ��Name$ 	AddButton��5      $��Добавить��6(   $��0,0,10,0q�6U   �� 5      -   5        $ 
EditButton��5      $ ��Редактировать��6)   $��0,0,10,0q�6\   �� 5      -   5        $ 	DelButton��5      $��Удалить��6(   6:   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ CustomersGrid��5         AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�6X      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 62   �� *
FullName+6O     5      $ Телефон��6%   $		 150 6P   
 66   �� *Phone+6P     5      $ Email��6%   $		 200 6N   
 64   �� *Email+6N   5      5      5      