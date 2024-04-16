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
using System.Windows.Media.Animation;
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
        private void AcceptFrame2(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Frame3());

        }
        private void txtChng(object sender, RoutedEventArgs e)
        {
            if (TB1.Text == "")
            {
                placeHolder1.Visibility = Visibility.Visible;
            }
            else
            {
                placeHolder1.Visibility = Visibility.Hidden;
            }
            if (TB2.Text == "")
            {
                placeHolder2.Visibility = Visibility.Visible;
            }
            else
            {
                placeHolder2.Visibility = Visibility.Hidden;
            }
            if (TB3.Text == "")
            {
                placeHolder3.Visibility = Visibility.Visible;
            }
            else
            {
                placeHolder3.Visibility = Visibility.Hidden;
            }

        }

        private void focusOn(object sender, RoutedEventArgs e)
        {

            ColorAnimation buttonAnimation = new ColorAnimation();
            buttonAnimation.From = Color.FromRgb(251, 185, 17);
            buttonAnimation.To = Color.FromRgb(210, 150, 13);
            buttonAnimation.Duration = TimeSpan.FromSeconds(0.2);
            button.Background.BeginAnimation(SolidColorBrush.ColorProperty, buttonAnimation);
        }
        private void focusOut(object sender, RoutedEventArgs e)
        {

            ColorAnimation buttonAnimation = new ColorAnimation();
            buttonAnimation.From = Color.FromRgb(210, 150, 13);
            buttonAnimation.To = Color.FromRgb(251, 185, 17);
            buttonAnimation.Duration = TimeSpan.FromSeconds(0.2);
            button.Background.BeginAnimation(SolidColorBrush.ColorProperty, buttonAnimation);
        }


    }
}
