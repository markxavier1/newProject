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
    /// Interaction logic for PageSettingRoType.xaml
    /// </summary>
    public partial class PageSettingRoType : Page
    {
        testEntities db;
        public PageSettingRoType()
        {
            InitializeComponent();
             db = new WpfApplication17.testEntities();
        }

        private void BtnStartMatch_Click(object sender, RoutedEventArgs e)
        {
            if (txtRTypeName.Text != "Enter Type")
            {
                RTypeTbl r = new WpfApplication17.RTypeTbl();
                r.RTypeName = txtRTypeName.Text;
                r.UpdateBy = Globel.User;
                r.UpdateDate = DateTime.Now;
                db.RTypeTbls.Add(r);
                db.SaveChanges();
            }

        }
    }
}
