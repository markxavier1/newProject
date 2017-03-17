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
    /// Interaction logic for PageRegister.xaml
    /// </summary>
    public partial class PageRegister : Page
    {
        EmployeeLayer ObjEmp = new EmployeeLayer();
        EmployeeTbl emp;
        List<Days> days;
        List<Times> times;
        public PageRegister()
        {

            InitializeComponent();
            emp = new EmployeeTbl();

            this.DataContext = emp;
            cbGender.ItemsSource = ObjEmp.Gender();
            cbType.ItemsSource = ObjEmp.ListOfType();
            days = ObjEmp.ListOfDay();
            times = ObjEmp.ListOfTime();
            cbDay.ItemsSource = days;

            cbTime.ItemsSource = times;
        }



        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            emp.IsActive = true;
            emp.UpdateBy = Globel.User;
            emp.UpdateDate = DateTime.Now;
            bool res = ObjEmp.AddEmployee(emp,days,times);
            if (res == true)
            {
                MessageBox.Show("Added");

            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
