   M S B A M L   `   `   `  ����  ButtonControl_TongHop&     ButtonControl_TongHop.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $��0* �6   �� 5      �� 5      $
��199* �6   .+�5   
   �� $��Hệ số a:��6   $
��Left=�6#   $��	5 ,35,0,0q�6>   $	��Top=�6Q   $��3��6i   �� 5   
   -   5         ��Name$
 txtA��5      $
��Left=�6!   $��6,66,0,0q�6<    �� TextWrapping$
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��780��6�   $��2��6�   �� 5   
   $��Hệ số b:��6   $
��Left=�6#   $��5,89,0,0q�6>   $	��Top=�6P    J� RenderTransformOrigin$ 
-0.47,0.66&�6h   $��55��6�   $��3��6�   �� 5   
   -   5        $
 txtB��5      $
��Left=�6    $��	6,120,0,0q�6;   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��780��6�   $��2��6�   �� 5   
   $
��Left=�6   $��	7,148,0,0q�6/   $
��Wrap=�6B   $��Kết quả: ��6V   $	��Top=�6g   $��2��6   �� 5   
   -   5         ��Name$ tbKetQua��5      $��Center=�6&   $��	0,164,0,0q�6C   $
��Wrap=�6V   $�� ��6j   $	��Top=�6r   
��� ���$	��776��6�   $��2��6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��3��6.   .+�5      �� -   5         ��Name$ btnTong��5      $	��100��6>   $��10q�6J   $��24��6V   .��5      �� $ 
Horizontal=�6   .+�5      �� $��/Images/sigma.png��6   �� 5      $	��5,0q�6    Tổng63   5      5      �� 5      -   5        $ btnThoat��5      $	��100��6A   $��10q�6M   $��24��6Y   .��5      �� $ 
Horizontal=�6   .+�5       �� $��/Images/Thoat.png��6   �� 5"      $	��5,0q�6    Thoát64   5#      5$      5%      5&      5'      