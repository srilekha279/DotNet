using EFDBFirstConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFirstConsoleApp.Services
{
    internal class StaffService
    {
        BykeStoresContext _context;
        public StaffService(BykeStoresContext cxt)
        {
            _context = cxt;
        }
        public void DisplayStaff()
        {
           foreach(var staff in _context.Staffs)
            {
                Console.WriteLine($"Id: {staff.StaffId} \tFirstName: {staff.FirstName}");
            }
        }
    }
}
