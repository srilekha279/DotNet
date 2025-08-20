using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOConsoleApp.Models
{
    internal class Staff
    {
        public int Staff_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public int Active { get; set; }
        public int Store_id { get; set; }
        public int Manager_id { get; set; }

    }
}
