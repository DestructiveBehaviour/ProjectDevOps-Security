   M S B A M L   `   `   `  ����L  HDevOpsProject_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:DevOpsProject_WPF.ViewsDevOpsProject_WPF.Views  5   	   3    -DevOpsProject_WPF.Views.CourseInformationView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:DevOpsProject_WPF.Views     5   	     N� Title$  CourseInformationView��5   	   $	��450��6'   $	��800��64   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Course Information��6   $��0��6-   $��0��6:   $��4��6J   
���   �$��20(�6q   $��Black"�6   $��Center=�6�   $��Center=�6�   �� 5   
   $��Course Name:��6   $��1��6'   $��0��64   $
��Left=�6D   $��Center=�6_   $��16(�6z   $��Black"�6�   �� 5   
   $��1��66   $��1��6C   $
��Left=�6S   $��Center=�6n   $��16(�6�   ��6   �� *Course.CourseName+6�   �� 5   
   $��	Language:��6   $��1��6$   $��2��61   $
��Left=�6A   $��Center=�6\   $��16(�6w   $��Black"�6�   �� 5   
   $��1��6:   $��3��6G   $
��Left=�6W   $��Center=�6r   $��16(�6�   ��6   �� *Course.CourseLanguage+6�   �� 5   
   $��Description:��6   $��2��6'   $��0��64   $
��Left=�6D   $��Center=�6_   $��16(�6z   $��Black"�6�   �� 5   
   $��2��6>   $��3��6K   $��1��6_   $
��0,15q�6o   $��16(�6}   ��6   �� *Course.CourseDescription+6}   �� 5    
   $��	Teachers:��6   $��3��6$   $��0��61   $��Center=�6A   $��Center=�6^   $��16(�6y   $��Black"�6�   �� 5!   
   $��4��63   $��0��6@   $��15q�6P   
���   �$��1q�6p   ��6   �� *
Teachers+ �� SelectedItem 6�   �� *TeacherToRemove+��5"      �� 5#      .R�5$      �� .+�5%      �� $��16(�6;   ��6$   �� *Name+6;   5&      5'      5)      �� 5*   
   $��4��66   $��1��6C   $��15q�6S   
���   �$��1q�6s   ��6   �� *TeachersNot+ 6�   �� *TeacherToAdd+��5+      �� 5,      .R�5-      �� .+�5.      �� $��16(�6;   ��6$   �� *Name+6;   5/      50      52      �� 53   
   $��Students enrolled:��6   $��3��6-   $��2��6:   $��Center=�6J   $��Center=�6g   $��16(�6�   $��Black"�6�   �� 54   
   $��Students eligible:��6   $��3��6-   $��3��6:   $��Center=�6J   $��Center=�6g   $��16(�6�   $��Black"�6�   �� 55   
   $��4��63   $��2��6@   $��15q�6Q   
���   �$��1q�6q   ��6   �� *
Students+ 6�   �� *StudentToRemove+��56      �� 57      .R�58      �� .+�59      �� $��16(�6;   ��6$   �� *Name+6;   5:      5;      5=      �� 5>   
   $��4��66   $��3��6C   $��15q�6T   
���   �$��1q�6t   ��6   �� *StudentsNot+ 6�   �� *StudentToAdd+��5?      �� 5@      .R�5A      �� .+�5B      �� $��16(�6;   ��6$   �� *Name+6;   5C      5D      5F      �� 5H   
   -   5         ��Name$  RegisterTeacherForClassBtn��5H      $��Register��65   $��6��6H   $��1��6U   
��� �|�$��5q�6|   ��6�   �� *RegisterTeacher+�� 5I   
   -   5        $ RegisterForClassBtn��5I      $��Register��6.   $��6��6A   $��3��6N   
��� �|�$��5q�6u   ��6�   �� *RegisterStudent+�� 5J   
   -   5        $" UnregisterTeacherForClassBtn��5J      $��
Unregister��67   $��6��6L   $��0��6Y   
����p��$��5q�6�   ��6�   �� *RemoveTeacher+�� 5K   
   -   5        $ UnregisterForClassBtn��5K      $��
Unregister��60   $��6��6E   $��2��6R   
����p��$��5q�6}   ��6�   �� *RemoveStudent+5N      5O      