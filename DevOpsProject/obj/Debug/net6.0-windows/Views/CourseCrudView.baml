   M S B A M L   `   `   `  ����L  HDevOpsProject_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:DevOpsProject_WPF.ViewsDevOpsProject_WPF.Views  5   	   ,    &DevOpsProject_WPF.Views.CourseCrudView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:DevOpsProject_WPF.Views     5   	     N� Title$  CourseCrudView��5   	   $	��450��6    $	��800��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Course Information��6   $��0��6-   $��0��6:   $��4��6J   
���   �$��20(�6q   $��Black"�6   $��Center=�6�   $��Center=�6�   �� 5   
   $��Course Name:��6   $��1��6'   $��0��64   $
��Left=�6D   $��16(�6`   $��Black"�6n   $��10q�6�   �� 5   
   -   5         ��Name$ CourseNameTextBox��5      $��1��6P   $��1��6]   $	��Top=�6m   $��10q�6�   ��6-   �� *Name+ �� Mode$ TwoWay=�6�   �� 5   
   $��	Language:��6   $��1��6$   $��2��61   $
��Left=�6A   $	��Top=�6\   $��16(�6t   $��Black"�6�   $��10q�6�   �� 5   
   -   5        $ CourseLanguageTextBox��5      $��1��6X   $��3��6e   $	��Top=�6u   $��16(�6�   $��10q�6�   ��61   �� *
Language+$ TwoWay=�6�   �� 5   
   $��Description:��6   $��2��6'   $��0��64   $	��Top=�6D   $��16(�6\   $��Black"�6j   $	�� 10q�6}   �� 5   
   $��2��6<   $��3��6I   $��1��6]   $��10q�6m   $��16(�6y   ��6   �� *Description+$ TwoWay=�6y   �� 5   
   $��Create/Update��6   $��0��6)   $��4��69   
���"�"���6F   �� *CreateAndUpdateCourseCommand+6�   5      5      