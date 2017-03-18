using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Times
    {
        public Times(string time)
        {
            Time = time;
            IsSelected = false;
        }
        public string Time { get; set; }
        public bool IsSelected { get; set; }

    }
}
