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
using System.Windows.Threading;

namespace IWT_RED
{
    

    public partial class Frame4 : Page
    {
        DispatcherTimer timer = new DispatcherTimer();

        public Frame4()
        {
            
            InitializeComponent();

            timerStart();
        }

        private void timerStart()
        {
            
            timer.Interval = TimeSpan.FromSeconds(20);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.NavigationService.Navigate(new Frame1());
        }
    }
}
