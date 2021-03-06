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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using DigitalJournal.Classes;
namespace DigitalJournal.Pages
{
    /// <summary>
    /// Interaction logic for CreatAccountPage.xaml
    /// </summary>
    public partial class CreatAccountPage : Page
    {
        LoginPage p1 = new LoginPage();
        UserInformation a = new UserInformation();
        TableColumns tc = new TableColumns();
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public CreatAccountPage()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            tc.UserDetailsColumn();
            List<string> UserNameList = tc.UserNameList;
            bool UN = false;

            foreach (string _u in UserNameList)
            {
                if(userName.Text == _u)
                {
                    UN = true;
                }
                else
                {
                    UN = false;
                }

            }
            if (UN == false)
            {
                if (passWord.Text != confPassword.Text)
                {
                    PassError.Text = "Passwords do not Match";
                }
                else
                {
                    PassError.Text = "Account Created!";
                    a.uservals = Userdetails();
                    a.CreateAccount();
                    PassError.Foreground = new SolidColorBrush(Colors.Green);
                    ReturntoLogin();
                }
            }
            else
            {
                PassError.Text = "UserName Taken";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pages.LoginPage p1 = new Pages.LoginPage();
            this.NavigationService.Navigate(p1);
        }
        public Array Userdetails()
        {
            string[] userdetails = new string[4];
            userdetails[0] = userName.Text;
            userdetails[1] = passWord.Text;
            userdetails[2] = firstName.Text;
            userdetails[3] = lastName.Text;
            return userdetails;
        }
        public async void ReturntoLogin()
        {
            await Task.Run(() => Task.Delay(2000));
            NavigationService.Navigate(p1);
        }
    }
}
