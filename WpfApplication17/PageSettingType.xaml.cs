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
using Core;

namespace WpfApplication17
{
    /// <summary>
    /// Interaction logic for PageSettingType.xaml
    /// </summary>
    public partial class PageSettingType : Page
    {
         EmployeeTypeTbl eType;
        SettingLayer setting;
        public PageSettingType()
        {
            InitializeComponent();
            eType = new EmployeeTypeTbl();
            setting = new SettingLayer();

        }

       

        private void BtnAddType_Click(object sender, RoutedEventArgs e)
        {
            eType.CreateBy = Globel.User;
            eType.CreateDate = DateTime.Now;
            eType.UpdateBy = Globel.User;
            eType.UpdateDate = DateTime.Now;
            bool res = setting.AddType(eType);
            if (res == true)
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
