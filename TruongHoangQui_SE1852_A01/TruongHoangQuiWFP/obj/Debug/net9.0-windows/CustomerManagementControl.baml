   M S B A M L   `   `   `  ����  TruongHoangQuiWFP1    +TruongHoangQuiWFP.CustomerManagementControl   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      $	��400��5      $	��600��6   .��5      � .+�5      �� $��10q�6   .+�5   
   ��   �� Orientation$  
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� -   5         ��Name$ 	txtSearch��5      $	��200��6)   $��0,0,10,0q�65   �� 5	      -   5        $��Tìm kiếm��5	      $��80��6(   63   �� 5
      -   5        $��Thêm��5
      $��80��6$   $��10,0,0,0q�6/   6A   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCustomers��5         AutoGenerateColumns$ False��5         
IsReadOnly$
 True��5         SelectionMode$ Single=�5      $	��300��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6P   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *
CustomerID+6P     5      $ Tên công ty��6%   $ * 6Z   	 6:   �� *CompanyName+6Z     5      $ Tên liên hệ��6%   $ * 6Z   	 6:   �� *ContactName+6Z     5      $
 SĐT��6%   $	 100 6L   	 62   �� *Phone+6L   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 	Tác vụ��6)   $	 140 69   
   CellTemplate
 5      �� 5      .R�5      �� $  
Horizontal=�6)   .+�5   "   �� -   5        $��Sửa��5   )   $��50��67   $��2q�6B   6M   �� 5   "   -   5        $
��Xóa��5   )   $��50��67   $��2q�6B   6M   5      5      5      5!      5"      5#      5$      