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

namespace WpfApplication17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            Globel.mainwindow = this;
            InitializeComponent();

            PageSettingRoType pagereg = new PageSettingRoType();

            FrameNavigate.Navigate(pagereg);

        }




        public void NavigatePages(string pagename)
        {

            PageRegister pagereg =null;
            switch (pagename)
            {

           
                case "PageRegister":
                    if (pagereg == null)
                    {
                        pagereg = new PageRegister();
                    }
                    this.FrameNavigate.Navigate(pagereg);
                    break;


                
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

          

        }
    }
}
