   M S B A M L   `   `   `  ����L  HDevOpsProject_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:DevOpsProject_WPF.ViewsDevOpsProject_WPF.Views  5      *    $DevOpsProject_WPF.Views.UserCrudView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:DevOpsProject_WPF.Views     5        N� Title$  UserCrudView��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Create/Update user��6   $��20(�6-   $��Black"�6;   $��4��6N   $��Center=�6b   $��Center=�6   �� 5   
   $��
First Name��6   $��1��6&   $��0��63   $	��Top=�6C   $��10q�6[   �� 5   
   -   5         ��Name$ FirstNameTextBox��5      $��1��6T   $��1��6a   $	��Top=�6q   $��10q�6�   ��6,   �� *	FirstName+ �� Mode$ TwoWay=�6�   �� 5   
   $��	Last Name��6   $��1��6$   $��2��61   $	��Top=�6A   $��10q�6Y   �� 5   
   -   5        $ LastNameTextBox��5      $��1��6R   $��3��6_   $	��Top=�6o   $��10q�6�   ��6+   �� *
LastName+$ TwoWay=�6�   �� 5   
   $��Username��6   $��2��6#   $��0��60   $	��Top=�6@   $��10q�6X   �� 5   
   -   5        $ UsernameTextBox��5      $��2��6R   $��1��6_   $	��Top=�6o   $��10q�6�   ��6+   �� *
Username+$ TwoWay=�6�   �� 5    
   $��Password��6   $��2��6#   $��2��60   $	��Top=�6@   $��10q�6X   �� 5!   
   -   5        $ PasswordTextBox��5!      $��2��6R   $��3��6_   $	��Top=�6o   $��10q�6�   ��6+   �� *
Password+$ TwoWay=�6�   �� 5"   
   $��Email��6   $��3��6    $��0��6-   $	��Top=�6=   $��10q�6U   �� 5#   
   -   5        $ EmailTextBox��5#      $��3��6L   $��1��6Y   $	��Top=�6i   $��10q�6�   ��6(   �� *Email+$ TwoWay=�6�   �� 5%   
   $��3��6   $��2��6    $	��Top=�6_   $��10q�6w   
���   �$��1q�6�   $��3q�6�    �� SelectedItem 60   �� *
UserType+$ TwoWay=�.@�5&      �� $��Student��6   6/   �� 5'      $��Teacher��6   6/   �� 5(      $��Administrator��6   65   5)      �� 5*   
   $��Create/Update��6   $��0��6)   $��4��69   ��6F   �� *CreateAndUpdateCommand+6s   5,      5-      