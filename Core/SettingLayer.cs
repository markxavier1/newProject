using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class SettingLayer
    {
        testEntities db;
        public SettingLayer()
        {
            db = new Core.testEntities();

        }
        public bool AddRtype(RoomTypeTbl rt, string User)
        {
            if (rt != null)
            {
                try
                {
                    int max = db.RoomTypeTbls.Max(r => r.RowId);
                    rt.RoomTypeID = GetID(max, "Room");
                    rt.UpdateBy = User;
                    rt.UpdateDate = DateTime.Now;
                    db.RoomTypeTbls.Add(rt);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;

        }

        public bool AddType(EmployeeTypeTbl et, string User)
        {
            if (et != null)
            {
                try
                {
                    int max = db.EmployeeTypeTbls.Select(e=>e.RowId).DefaultIfEmpty(0).Max();
                    et.EmployeeTypeID = GetID(max, "St");
                    et.UpdateBy = User;
                    et.UpdateDate = DateTime.Now;
                    db.EmployeeTypeTbls.Add(et);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;

        }

        public List<string> ListOfDay()
        {
            List<string> day = new List<string>(new string[] { "Mon", "Tue", "Wed", "Thus", "Fri", "Sat", "Sun" });
            return day;

        }
        public List<string> ListOfTime()
        {
            List<string> day = new List<string>(new string[] { "10:00AM-11:00AM", "11:00AM-12:00PM", "12:00PM-01:00PM", "01:00PM-02:00PM", "02:00PM-03:00PM", "03:00PM-04:00PM", "04:00PM-05:00PM", "05:00PM-06:00PM", "06:00PM-07:00PM", "07:00PM-08:00PM", "08:00PM-09:00PM" });
            return day;

        }

        private string GetID(int? Max, string Type)
        {
            if (Max == null)
            {
                Max = -001;
            }
            return Type + DateTime.Now.Year.ToString() + (Max + 1).ToString();
        }
    }
}
