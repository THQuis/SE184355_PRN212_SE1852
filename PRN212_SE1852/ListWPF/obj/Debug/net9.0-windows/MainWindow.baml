   M S B A M L   `   `   `  ����B  >ListWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ListWPFListWPF  5   	       ListWPF.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ListWPF     5   	     � Title$  Thao tác trên List��5   	   $	��360��6$   $	��282��61   .��5	      � .+�5
   
   �� -   5         ��Name$ 	txtGiaTri��5
      $
��Left=�5   	   $��23��6$   $��	17,10,0,0q�5   	    �� TextWrapping$
 Wrap=�6   $	��Top=�5   	   $��98��6!   �� 5   
   -   5         ��Name$ btnThem��5      $��Thêm vào List��6"   $
��Left=�5   	   $��
127,13,0,0q�6$   $	��Top=�5   	   $	��115��6!    J� RenderTransformOrigin$ 0.341,0.611&�5   	   5   	   �� 5   
   -   5         ��Name$ 	lstDuLieu��5       �� SelectionMode$ Multiple=�6%   $
��Left=�5   	   $	��275��6$   $��	15,38,0,0q�5   	   $	��Top=�6   $	��100��5   	   �� 5   
   -   5        $ btnSapXepTang��5      $��Sắp xếp tăng��5   	   $
��Left=�6    $��127,143,0,0q�5   	   $	��Top=�6   $	��115��5   	   6   �� 5   
   -   5        $ btnSapXepGiam��5      $��Sắp xếp giảm��5   	   $
��Left=�6    $��127,180,0,0q�5   	   $	��Top=�6   $	��115��5   	   6   �� 5   
   -   5        $ btnXoa1PhanTu��5      $��Xóa 1 phần tử��5    	   $
��Left=�6!   $��127,220,0,0q�5!   	   $	��Top=�6   $	��115��5"   	   6   �� 5#   
   -   5        $ btnXoaNhieuPhanTu��5#      $��Xóa nhiều phần tử��5$   	   $
��Left=�5%   	   $��127,256,0,0q�6$   $	��Top=�5&   	   $	��115��6!   5'   	   �� 5(   
   -   5        $ btnXoaToanBoPhanTu��5(      $!��Xóa toàn bộ phần tử��5)   	   $
��Left=�5*   	   $��127,293,0,0q�6$   $	��Top=�5+   	   $	��115��6!   5,   	   �� 5-   
   $��Giá trị:��6   $
��Left=�6#   $��
127,45,0,0q�5.   	   $	��Top=�6   �� 50   
   -	   5        $ txtGiaTriChen��50      $
��Left=�51   	   $��23��6$   $��
176,48,0,0q�52   	   $
 Wrap=�6   $	��Top=�53   	   $��66��6!   �� 54   
   $��
Vị trí:��6   $
��Left=�6"   $��
127,73,0,0q�55   	   $	��Top=�6   �� 56   
   -
   5        $ txtViTriChen��56      $
��Left=�57   	   $��23��6$   $��
176,76,0,0q�58   	   $
 Wrap=�6   $	��Top=�59   	   $��66��6!   $ 	0.48,1.71&�5:   	   �� 5;   
   -   5        $ btnChen��5;      $��Chèn��6"   $
��Left=�5<   	   $��176,111,0,0q�6$   $	��Top=�5=   	   $��66��6!   5>   	   5?      5@      