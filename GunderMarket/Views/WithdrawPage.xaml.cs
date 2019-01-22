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

namespace GunderMarket
{
    /// <summary>
    /// Interaction logic for WithdrawPage.xaml
    /// </summary>
    public partial class WithdrawPage : Window
    {
        public static WithdrawWindowViewModel WithdrawWindowViewModel = new WithdrawWindowViewModel();
        public WithdrawPage()
        {
            InitializeComponent();
            this.DataContext = WithdrawWindowViewModel;
        }
    }
}
