   M S B A M L   `   `   `  ����  TruongHoangQuiWFP%    TruongHoangQuiWFP.ProductDialog   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Thông tin sản phẩm��5   	   $	��480��6$   $	��400��61    � WindowStartupLocation$ CenterOwner=�5   	    � 
ResizeMode$ NoResize=�6-    � SizeToContent$ Height=�5   	   .��5      �� $��20q�6   .+�5   
   �� $��Tên sản phẩm:��6   �� 5	   
   -   5         ��Name$ txtProductName��5	      $	��250��6*   �� 5   
   $��Danh mục (CategoryID):��6   $��0,8,0,0q�62   �� 5   
   -   5        $ txtCategoryID��5      $	��250��6)   �� 5   
   $��Giá:��6   $��0,8,0,0q�6    �� 5   
   -   5        $ txtUnitPrice��5      $	��250��6(   �� 5   
   $��
Tồn kho:��6   $��0,8,0,0q�6$   �� 5   
   -   5        $ txtUnitsInStock��5      $	��250��6+   �� 5   
   $!��Số lượng đặt hàng:��6   $��0,8,0,0q�6.   �� 5   
   -   5        $ txtUnitsOnOrder��5      $	��250��6+   �� 5   
   $��Mức đặt lại:��6   $��0,8,0,0q�6(   �� 5   
   -   5        $ txtReorderLevel��5      $	��250��6+   �� 5   
   $��Đơn vị đóng gói:��6   $��0,8,0,0q�6,   �� 5   
   -   5        $ txtQuantityPerUnit��5      $	��250��6.   �� 5   
   $��Danh mục:��6   $��0,8,0,0q�6%   �� 5   
   -   5         ��Name$ 
cbCategory��5      $	��250��6'    �� DisplayMemberPath$ CategoryName��5       �� SelectedValuePath$ 
CategoryID��5      �� 5"   
   -	   5         ��Name$ chkDiscontinued��5"      $��Ngừng bán��6,   $��0,10,0,0q�6@   �� 5$   
   	 �� Orientation$	 
Horizontal=�6   $��Right=�6.   $��0,15,0,0q�6J   .+�5%      �� -
   5        $
��Lưu��5%      $��70��6#   $��0,0,10,0q�6.   6@   �� 5&      -   5        $��Hủy��5&      $��70��6#   6.   5'      5(      5)      