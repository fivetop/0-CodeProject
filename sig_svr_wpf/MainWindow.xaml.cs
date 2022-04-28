﻿using DataClass;
using System;
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

namespace sig_svr_wpf
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignalRMsg s1 = new SignalRMsg();
            s1.message = "hi";
            App._hub.MessageS2C2(s1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SignalRMsg s1 = new SignalRMsg();
            s1.message = "hi2";
            App._hub.MessageS2C2(s1);

        }
    }
}
