   M S B A M L   `   `   `  ����F  BJewelryShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:JewelryShop.ModalViewsJewelryShop.ModalViews  5   	   '    !JewelryShop.ModalViews.SaleDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:JewelryShop.ModalViews     5   	     � Title$  Новая продажа��5   	   $	��500��6   $	��600��6,    � WindowStartupLocation$ CenterOwner=�68   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��0,0,0,5q�6;   .+�5      �� $��Покупатель:��6   $��Center=�6+   �� 5      -   5         ��Name$ CustomerBox��5      $	��200��6,   $
��10,0q�68    �� DisplayMemberPath$ FullName��6F   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��0,0,0,10q�6;   .+�5      �� $��	Дата:��6   $��Center=�6%   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 
DatePicker��5      $	��150��6-   $��46,0,0,0q�69   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	ItemsGrid��5      $��2��6&      AutoGenerateColumns .  	   CanUserAddRows	 . 
   Columns
 5      4  .System.Windows.Controls.DataGridComboBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Товар��6)      SelectedValuePath$ Id��5   )      DisplayMemberPath$
 Name��6@      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y      SelectedValueBinding 5   8   �� *	ProductId+5   Y   0  *System.Windows.Controls.DataGridTextColumn  5      $ Количество��6%   $	 100 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
Quantity+6V   5!      �� 5#   
   $��3��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5$      �� -   5        $��Сохранить��5$      $	��100��6)   $��5q�65   6@   �� 5%      -   5        $��Отмена��5%      $	��100��6&   $��5q�62   6=   5&      5'      5(      