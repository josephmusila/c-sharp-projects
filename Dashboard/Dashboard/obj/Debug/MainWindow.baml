   M S B A M L   `   `   `  ����D  @Dashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Dashboard	Dashboard  5   	       Dashboard.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Dashboard     5   	     � Title$  
MainWindow��5   	   $	��600��5	   	   $	��800��6    � 
ResizeMode$ NoResize=�5
   	    � Topmost .  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   � 
���   �.+�5      � -   5         �Name$ nav_pnl��5      $
��Left=�5      $��65��5      ���#2E333A.+�5      �� -   5         ��Name$ sk_pnl��5      .+�5      � $��90��6   .+�5      d� -   5         d�Name$ tg_Btn��5   '   $��0��5   '   $��Center=�5   '   $��Center=�5   '   $��
18,-20,0,0q�5   '   $��30��5   '   $��30��5   '   $��0q�5    '   ��5"      �� 5#   "    �� ImageSource$5 /Assets\c88aba45-ecd4-41f3-af93-e3cb8e7219a6.png��6-   	 j� Stretch$
	 none=�5$   -   
 � Triggers
 5(      :� 5)   "    :� RoutedEvent$ ToggleButton.Unchecked��6/   .[�5*   &   �� .��5+   *   �� -   5         ��Name$ HideStackPanel��5+   5   .��5,   .   W�  �� 
TargetName$ nav_pnl��5-   1    �� TargetProperty$ Width�5.   1    g� 	BeginTime$ 0:0:0X�5/   1    W� From$	 230X�50   1   	 W� To$ 65X�51   1    g� Duration$ 0:0:0.2D�52   1   55   /   56   +   57   '   58   #   5:      5;      5<      5>      5A      5B      5C      