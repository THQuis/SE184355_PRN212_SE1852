   M S B A M L   `   `   `  ����G  CHelloWWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HelloWWPFAppHelloWWPFApp  5   	       HelloWWPFApp.LoginWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:HelloWWPFApp     5   	     � Title$  LoginWindow��5   	   $	��450��6   $	��800��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��119* �6   �� 5      $
��281* �6   .+�5   
   �� $��_User Name:��6   $
��Left=�5      $��	46,45,0,0q�6+   $	��Top=�6>    �� Target 5      ��  �� ElementName$ txtUserName��5   >   �� 5   
   $��
_Password:��6   $
��Left=�5      $��
46,101,0,0q�6+   $	��Top=�6?    5      �� $ txtPassword��5   ?   �� 5   
   -   5         ��Name$ txtUserName��5      $
��Left=�6'   $��
129,49,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��120��6�   $��2��6�   G� 5   
   -   5         G�Name$ txtPassword��5      $
��Left=�6+   $��129,105,0,0q�6F   $	��Top=�6[   $	��120��6s    G� Password$  ��6   $��2��6�   �� 5   
   -   5         ��Name$ btnDangNhap��5      $��Đăng nhập��6&   $
��Left=�6:   $��127,155,0,0q�6U   $	��Top=�6j   6�   �� 5   
   -   5        $ btnThoat��5      $��Thoát��6#   $
��Left=�63   $��215,155,0,0q�6N   $	��Top=�6c   $��2��6�   5      5      