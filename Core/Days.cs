using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Days
    {
        public Days(string day)
        {
            Day = day;
            IsSelected = false;

        }
        public string Day { get; set; }
        public bool IsSelected { get; set; }

    }
}
