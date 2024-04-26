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
using IWT_RED.Helpers;

namespace IWT_RED
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigate.NavServ = frame.NavigationService;



            frame.Navigate(new Frame1());
            
        }

        private void keyDownAllFrame(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape) 
            {
                this.Close();
            }
        }




    }
}
