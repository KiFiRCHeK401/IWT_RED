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

namespace IWT_RED
{
    /// <summary>
    /// Логика взаимодействия для Frame2.xaml
    /// </summary>
    public partial class Frame2 : Page
    {
        public Frame2()
        {
            InitializeComponent();
            
        }
        public void AcceptFrame2(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Frame3());

        }

    }
}
