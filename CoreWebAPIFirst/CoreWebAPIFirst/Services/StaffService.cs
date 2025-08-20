using CoreWebAPIFirst.Models;
using Microsoft.AspNetCore.Mvc;
namespace CoreWebAPIFirst.Services
{
    public class StaffService
    {
        BykeStoresContext context = null;
       
        public StaffService(BykeStoresContext ctr)
        {
           context = ctr;
        }
       
        public List<Staff> GetStaffList()
        {
            return context.Staffs.ToList();
        }

        public Staff? GetStaffbyId(int id)
        {
            return context.Staffs.FirstOrDefault(s => s.StaffId == id);
        }

        
        //public int AddStaffService()
        //{
        //    Staff staff = new Staff();
        //    staff.FirstName = "Ben";
        //    staff.LastName = "Joe";
        //    staff.Phone = "991919110";
        //    staff.Email = "sdfs@gmail.com";
        //    staff.Active = 2;
        //    staff.StoreId = 1;
        //    staff.ManagerId = 2;

        //    context.Staffs.Add(staff);
        //    return context.SaveChanges();
        //}
        //public int AddStaffServiceInput(Staff input)
        //{
        //    return context.Staffs.FirstOrDefault()
        //}

        //public int PostStaff(Staff staff)
        //{
        //    context.Staffs.Add(staff);
        //    return context.SaveChanges();
        //}
    }
}
