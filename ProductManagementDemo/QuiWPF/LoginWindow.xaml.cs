﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessObject;
using Service;

namespace QuiWPF
{
   
    public partial class LoginWindow : Window
    {
        private readonly IAccountService iAccountService;

        public LoginWindow()
        {
            InitializeComponent();
            iAccountService = new AccountService();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AccountMember account = iAccountService.GetAccountById(txtUser.Text.Trim());
            if (account != null && account.MemberPassword == txtPass.Password.Trim() && account.MemberRole == 1)
            {
                this.Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
