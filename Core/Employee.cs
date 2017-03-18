using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class EmployeeLayer
    {
        testEntities db;
        public EmployeeLayer()
        {
            db = new Core.testEntities();

        }
        public bool AddEmployee(EmployeeTbl employee, List<Days> days, List<Times> times, byte[] ProfilePic, string User, bool IsActive = true)
        {
            if (employee != null)
            {
                try
                {
                    employee.IsActive = IsActive;
                    employee.Day = workingDays(days);
                    employee.Time = workingTimes(times);
                    employee.Image = imageValidation(ProfilePic); //add PP.jpg at Bin Dir
                    db.EmployeeTbls.Add(employee);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private byte[] imageValidation(byte[] img) //No benfit 
        {
            try
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory;

                if (img == null)
                {
                    img = File.ReadAllBytes(path + @"pp.jpg");
                    return img;

                }
                return img;
            }
             catch { return null; }
        }
        public List<Days> ListOfDay()
        {

            List<Days> day = new List<Days>();

            string[] d = new string[] { "Mon", "Tue", "Wed", "Thus", "Fri", "Sat", "Sun" };
            for (int i = 0; i <= d.Length - 1; i++)
            {
                day.Add(new Days(d[i]));
            }
            return day;

        }
        public List<Times> ListOfTime()
        {
            List<Times> time = new List<Times>();
            string[] t = new string[] { "10:00AM-11:00AM", "11:00AM-12:00PM", "12:00PM-01:00PM", "01:00PM-02:00PM", "02:00PM-03:00PM", "03:00PM-04:00PM", "04:00PM-05:00PM", "05:00PM-06:00PM", "06:00PM-07:00PM", "07:00PM-08:00PM", "08:00PM-09:00PM" };
            for (int i = 0; i <= t.Length - 1; i++)
            {
                time.Add(new Times(t[i]));
            }
            return time;

        }
        public List<string> Gender()
        {
            List<string> gender = new List<string>(new string[] { "Male", "Female" });
            return gender;

        }
        public List<string> ListOfType()
        {
            return db.EmployeeTypeTbls.Select(a => a.EmployeeTypeName).ToList();

        }
        private string workingDays(List<Days> days)
        {
            string d = "";
            foreach (Days item in days)
            {
                if (item.IsSelected == true)
                {
                    d = d + item.Day + ",";
                }
            }
            return d;

        }
        private string workingTimes(List<Times> times)
        {
            string d = "";
            foreach (Times item in times)
            {
                if (item.IsSelected == true)
                {
                    d = d + item.Time + ",";
                }
            }
            return d;

        }

    }


    
}
