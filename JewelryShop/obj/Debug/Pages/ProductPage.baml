   M S B A M L   `   `   `  ����F  BJewelryShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:JewelryShop.PagesJewelryShop.Pages  5      #    JewelryShop.Pages.ProductPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:JewelryShop.Pages     5      $	��450��5      $	��800��6     N� Title$  Товары��5      .��5
      ]� $��10q�6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $��0,0,0,10q�6C   .+�5      �� -   5         ��Name$ 	AddButton��5      $��Добавить��6(   $��0,0,10,0q�6M   �� 5      -   5        $ 
EditButton��5      $ ��Редактировать��6)   $��0,0,10,0q�6T   �� 5      -   5        $ 	DelButton��5      $��Удалить��6(   6:   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ProductsGrid��5         AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�6W      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *Name+6P     5      $ Категория��6%   $		 120 6U   
 68   �� *
Category+6U     5      $ Материал��6%   $		 120 6T   
 67   �� *
Material+6T     5      $ 
Проба��6%   $	 80 6O   
 64   �� *Purity+6O     5      $ Вес��6%   $	 80 6M   
 62   �� *Weight+6M     5      $ Цена��6%   $		 100 6M   
 63   �� *Price+6M   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ В наличии��6)   $	 80 6X   
 6<   �� *	InStock+6X   5      5      5      