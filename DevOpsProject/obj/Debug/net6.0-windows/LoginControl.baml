   M S B A M L   `   `   `  ����L  HDevOpsProject_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DevOpsProject_WPFDevOpsProject_WPF  5      $    DevOpsProject_WPF.LoginControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:DevOpsProject_WPF     5      .��5	      � .+�5
   
   �� 
�������  �� CornerRadius$  6��5      $��244,69,244,69q�6    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$	 -90Q�63      RenderingBias$ Quality=�6E      ShadowDepth$ 2Q�6^      Color$
 Gray��6o   ._�5      ��  �� Orientation$ Vertical=�6   $��20q�5      .+�5      �� $��Login��6   $��25(�6)   $��Center=�67   $	��Top=�6T   $
��Bold"�5       �� Padding$ 10q�6*   � 5      $��Center=�6   	 � RowDefinitions	 5      �� 5      $
��Auto �6(   �� 5      $��* �6(   �� 5      $
��Auto �6(   �� 5      $��* �6(   
 � ColumnDefinitions
 5      �� 5      $��* �6+   �� 5      $��* �6+   .+�5       �� $��	User Name��6    $��0��5!      $	��0,5q�5"      $
��Left=�5#      �� 5$      $��1��6=   $��1��6J   
���  ����6   �� *Errormessage+6Z   �� 5%      -   5         ��Name$ UsernameTextBox��5%      $��1��67   $��5q�6D   $
��Left=�6P   $	��0.5q�5&      
���   �$��5q�6I   $��2��6T   $	��150��6h   �� 5'      $��Password��6    $��2��60   $	��0,5q�6=   $
��Left=�6J   $��2��6e   G� 5(      -   5         G�Name$ PasswordBox��5(   "   $��3��67    G� Password$ Random��6D   $��5q�6V   $��5q�6b   $	��0.5q�6m   
���   �$
��Left=�5)   6   $��2��6Q   $	��150��6e   5*      �� 5+      -   5         ��Name$ LoginBtn��5+      $��Login��6+   
�������
���   �$��35��6a   $	��250��5,      $��4q�6!   ��5-      �� 5.       �� 
TargetType" ��6    .�5/      ��  �� Property � �� �� Value 50   "   �� 51   &    �� 
TargetType" ��66   .R�52   *   ��  ��Name$ LoginBorder��61   #��z��6F   $  16��53   -   ._�54   .   �� $��Center=�6?   $��Center=�55   ;   56   +    �� Triggers 57   *   P� 58   .    P� Property �@J�IsMouseOver P� Value$
 True��6M   . �59   2   ��  �� 
TargetName$ LoginBorder��6a    � ��
 ������� 5:   2   $ LoginBorder��6h    � ��
 �   �5;   /   5=   '   5?      5@      5B      �� 5C      -   5        $ 	SignUpBtn��5C      $��Sign Up��6,   
���   ����	#00000000$��35��5D      $	��250��6!   ��5E      �� 5F      " ��6    .�5G      ��  � �� 5H   "   �� 5I   &   " ��66   .R�5J   *   �� $ LoginBorder��61   #��z��6F   $  16��5K   1   
���   �$��1q�6W   ._�5L   .   �� $��Center=�6?   $��Center=�5M   ;   5N   +    5O   *   P� 5P   .    �@J�IsMouseOver$
 True��6M   . �5Q   2   �� $ LoginBorder��6a    � ��
 ������� 5R   2   $ LoginBorder��6h    � ��
 �   �5S   /   5U   '   5W      5X      5Z      5[      5\      5]      5^      