   M S B A M L   `   `   `  ����L  HDevOpsProject_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:DevOpsProject_WPF.ViewsDevOpsProject_WPF.Views  5   	   *    $DevOpsProject_WPF.Views.OverviewView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:DevOpsProject_WPF.Views     5   	     N� Title$  OverviewView��5   	   $	��550��6   $	��800��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� 
���   �$��20(�6#   $��Black"�61   $��Center=�6D   $��Center=�6a   $��0��6|   $��0��6�   $��Course Overview��6�   �� 5   
   $��1��6   $��3��6   $��15q�63   ��6?   �� *	Courses+ �� SelectedItem 5      �� *SelectedCourse+��5      �� 5      .R�5      �  5      �� 5      $��* �6/   �� 5      $��* �6/   �� 5      $��* �6/   .+�5       �� $��0��6$   $��5q�6P   ��64   �� *
CourseName+6P   �� 5!      $��1��6$   $��5q�6W   ��64   �� *CourseDescription+6W   �� 5"      $��2��6$   $��5q�6T   ��64   �� *CourseLanguage+6T   5#      5$      ��5&      �� 5'       �� 
TargetType" ��6   .�5(      ��  �� Property � �� �� Value 5)      �� 5*       �� 
TargetType" ��6.   .R�5+   "   �� 
�������$��0,0,0,1q�6<   ._�5-   &   �� 5.   #   5/      51      52      54      �� 55   
   $��0��6   $��2��6!   $��Delete��6.   $��50,15q�6i   
����p����6?   �� *DeleteSelectedCommand+6x   �� 56   
   $��1��6   $��2��6!   $��Show Information��6.   $��50,15q�6s   ��6I   �� *ShowCourseInfoCommand+6s   �� 57   
   $��2��6   $��2��6!   $��Create New Course��6.   $��50,15q�6u   
���"�"���6J   �� *CreateNewCourseCommand+6�   59      5;      