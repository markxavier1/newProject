using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace WpfApplication17
{
    /// <summary>
    /// Interaction logic for PageRegister.xaml
    /// </summary>
    public partial class PageRegister : Page
    {
        EmployeeLayer ObjEmp = new EmployeeLayer();
        EmployeeTbl emp;
        List<Days> days;
        List<Times> times;
        byte[] imgData = null;
        public PageRegister()
        {
            InitializeComponent();
            emp = new EmployeeTbl();
            this.DataContext = emp;
            LoadAll();
        }
         private void LoadAll()
         {
            cbGender.ItemsSource = ObjEmp.Gender();
            cbType.ItemsSource = ObjEmp.ListOfType();
            days = ObjEmp.ListOfDay();
            times = ObjEmp.ListOfTime();
            cbDay.ItemsSource = days;
            cbTime.ItemsSource = times;

        }


        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            bool res = ObjEmp.AddEmployee(emp, days, times, imgData, Globel.User);
            if (res == true)
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        private void BtnPicUpload_Click(object sender, RoutedEventArgs e)
        {
            string filename;
            OpenFileDialog ofdd = new OpenFileDialog();
            ofdd.Filter = "JPEG (*.jpg)|*.jpg|Windows bitmap (*.bmp)|*.bmp|All files|*.*";
            if (ofdd.ShowDialog() == true)
            {
                try
                {
                    filename = ofdd.FileName;
                    //  x = ofdd.SafeFileName;
                    imgprofilepic.Source = new BitmapImage(new Uri(filename)); ;
                    imgData = File.ReadAllBytes(filename);

                }
                catch
                {
                    MessageBox.Show("File Not Supported");
                }
            }
        }
    }
}
