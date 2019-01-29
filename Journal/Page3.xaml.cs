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

namespace Journal
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : System.Windows.Controls.Page
    {
        Page4 p4 = new Page4();
        Page5 p5 = new Page5();
        public Page3()
        {
            InitializeComponent();
        }

        private void Entries_Click(object sender, RoutedEventArgs e)
        {
            
            this.NavigationService.Navigate(p4);
        }

        private void NewEntry_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(p5);
        }
    }
}
