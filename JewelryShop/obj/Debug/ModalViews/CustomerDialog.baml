   M S B A M L   `   `   `  ����F  BJewelryShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:JewelryShop.ModalViewsJewelryShop.ModalViews  5   	   +    %JewelryShop.ModalViews.CustomerDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:JewelryShop.ModalViews     5   	     � Title$  Покупатель��5   	   $	��250��6   $	��400��6)    � WindowStartupLocation$ CenterOwner=�65    � 
ResizeMode$ NoResize=�6Y   .��5      � $��10q�6    � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��ФИО:��6   $��0��6    $��0,0,0,5q�6-   �� 5   
   -   5         ��Name$ FullNameBox��5      $��0��6'   $��80,0,0,5q�64   �� 5   
   $��Телефон:��6   $��1��6$   $��0,5,0,5q�61   �� 5   
   -   5        $ PhoneBox��5      $��1��6$   $��80,5,0,5q�61   �� 5   
   $��Почта:��6   $��2��6"   $��0,4,0,23q�6/   �� 5   
   -   5        $ EmailBox��5      $��2��6$   $��	80,5,0,23q�61   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��
0,57,0,-42q�6W   .+�5      �� -   5        $��Сохранить��5      $��80��6)   $��5q�64   6?   �� 5      -   5        $��Отмена��5      $��80��6&   $��5q�61   6<   5      5      5      