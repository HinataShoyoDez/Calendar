   M S B A M L   `   `   `  ����D  @Calendars, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Calendars	Calendars  5          Calendars.ShowDate   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Calendars     5        N� Title$  ShowDate��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5        $��Düzenle��5      $��75��6'   $��0,15,0,0q�62   $��Right=�6D   $��0��6`   $��25��6m   6y   �� 5      -   5        $	��Sil��5      $��75��6#   $��
15,15,15,0q�6.   $��Right=�6B   $��0��6^   $��25��6k   6w   �� 5      -   5        $
��Geri��5      $��75��6$   $��0,15,0,0q�6/   $��Right=�6A   $��0��6]   $��25��6j   6v   5      �� 5   
   -   5         ��Name$ RemindersListBox��5      $��1��6,   ��5      �� 5      .R�5      �� .+�5      �� $
��Bold"�6S   ��6$   �� *date+ �� StringFormat$ 
MM/dd/yyyy��6S   �� 5      ��6$   �� *	message+5      5      5       5!      5"      