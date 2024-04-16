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

namespace IWT_RED
{
    /// <summary>
    /// Логика взаимодействия для Frame3.xaml
    /// </summary>
    public partial class Frame3 : Page
    {
        public Frame3()
        {
            InitializeComponent();
            TB4.Focus();
        }

        private void GetCodeAgane(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("код: 000");
        }
        private void keyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                GoNextFrame();
            }
        }
        private void AcceptFrame3(object sender, MouseButtonEventArgs e)
        {
            GoNextFrame();
        }

        private void GoNextFrame()
        {
            string trueCode = "000";
            string str = TB4.Text + TB5.Text + TB6.Text;
            if (trueCode != str)
            {
                MessageBox.Show("неверный код");
                TB4.Text = "";
                TB5.Text = "";
                TB6.Text = "";
                TB4.Focus();
            }
            else
            {
                this.NavigationService.Navigate(new Frame4());
            }
        }

        private void TextChanged1(object sender, TextChangedEventArgs e)
        {
            if (TB4.Text != "")
            {
                TB5.Focus();
                TB5.Select(TB4.Text.Length, 0);
                return;
            }

        }
        private void TextChanged2(object sender, TextChangedEventArgs e)
        {

            if (TB5.Text != "")
            {
                TB6.Focus();
                TB6.Select(TB4.Text.Length, 0);
                return;
            }
        }

        private void TextChanged3(object sender, TextChangedEventArgs e)
        {

        }
    }
}
