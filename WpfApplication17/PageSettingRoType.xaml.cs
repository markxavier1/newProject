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
using Core;


namespace WpfApplication17
{
    /// <summary>
    /// Interaction logic for PageSettingRoType.xaml
    /// </summary>
    public partial class PageSettingRoType : Page
    {


        RTypeTbl rType;
        SettingLayer setting;
        public PageSettingRoType()
        {
            InitializeComponent();
            rType = new RTypeTbl();
            this.DataContext = rType;
            setting = new SettingLayer();
        }

      

        private void BtnAddRType_Click(object sender, RoutedEventArgs e)
        {
            rType.CreateBy = Globel.User;
            rType.CreateDate = DateTime.Now;
            rType.UpdateBy = Globel.User;
            rType.UpdateDate = DateTime.Now;
            bool res = setting.AddRtype(rType);
            if(res==true)
            {
                MessageBox.Show("Added");
               
            }
           else
            {
                MessageBox.Show("error");

            }
        }
    }
}
