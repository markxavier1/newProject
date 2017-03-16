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
    /// Interaction logic for PageSettingType.xaml
    /// </summary>
    public partial class PageSettingType : Page
    {
        testEntities db;
        public PageSettingType()
        {
            InitializeComponent();
            db = new WpfApplication17.testEntities();

        }

        private void BtnStartMatch_Click(object sender, RoutedEventArgs e)
        {
            EmployeeTypeTbl emp = new WpfApplication17.EmployeeTypeTbl();
            emp.EmployeeTypeName = txtTypeName.Text;
            //emp.UpdateBy = Globel.User;
            //emp.UpdateDate = DateTime.Now;
            db.EmployeeTypeTbls.Add(emp);
            db.SaveChanges();

        }
    }
}
