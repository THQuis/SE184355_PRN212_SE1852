   M S B A M L   `   `   `  ����L  HTruongHoangQuiWFP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TruongHoangQuiWFPTruongHoangQuiWFP  5      .    (TruongHoangQuiWFP.OrderManagementControl   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TruongHoangQuiWFP     5      .��5	      � $��10q�6     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��Tạo đơn hàng mới��5      $	��150��6,   $��30��68   $
��Left=�5      6,   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgOrders��5      $��1��6%      AutoGenerateColumns$ False��62      
IsReadOnly$
 True��5         SelectionMode$ Single=�6%      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã đơn��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	OrderID+6Q     5      $ Khách hàng��6%   $ * 6X    69   �� *
CustomerID+6X     5      $ Nhân viên��6%   $ * 6W    68   �� *
EmployeeID+6W     5      $ Ngày đặt��6%   $	 150 6U    67   �� *	OrderDate+6U   5      �� 5   
   $��Chi tiết đơn hàng��6   $��2��6.   $��0,10,0,0q�6;   .��5        -   5        $ dgOrderDetails��5      $ False��6/   $
 True��6K    5        5       $ Sản phẩm��6)   $ * 6Y    6;   �� *	ProductID+6Y     5!      $
 Giá��6)   $	 100 6T    66   �� *	UnitPrice+6T     5"      $ Số lượng��6)   $	 100 6X    6;   �� *
Quantity+6X     5#      $ Chiết khấu (%)��6)   $	 100 6^    6A   �� *
Discount+6^   5%      5&      5'      5(      