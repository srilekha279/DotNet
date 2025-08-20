using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWebAPIFirst.Models;
using CoreWebAPIFirst.Services;

namespace CoreWebAPIFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StaffsController : ControllerBase
    {
        StaffService ss = null;
        public StaffsController(BykeStoresContext ctr)
        {
            ss = new StaffService(ctr);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Staff>> GetStaffs()
        {
            //Call service class GetStaffs method
            //List<Staff> staffs = ss.GetStaffList();
            //return staffs;

            List<Staff> staffs = ss.GetStaffList();
            if(staffs == null || staffs.Count == 0)
            {
                return NotFound("No staff records found");
            }
            return Ok(staffs);
        }
        
        [HttpGet("GetStaffbyId/{id}")]
        public ActionResult<Staff> GetStaffbyId(int id)
        {
            Staff stf = ss.GetStaffbyId(id);
            if(stf == null)
            {
                return NotFound("No staff records found with id " + id);
            }
            return Ok(stf);
        }

        //[HttpPost("AddStaffbyInput")]
        //public ActionResult<int>AddStaffbyInput()
        //{
        //    int recordsAffected = ss.AddStaffServiceInput();
        //    return recordsAffected;
        //}

        //[httppost("addstaff")]
        //public actionresult<int> addstaff([frombody] staff staff)
        //{
        //    context.staffs.add(staff);
        //    int recordsaffected = context.savechanges();
        //    int recordsaffected = context.savechanges();
        //    return ok(recordsaffected);
        //}
        //[HttpPost("PostStaff")]
        //public ActionResult<Staff> PostStaff([FromBody] Staff stf)
        //{
        //    int result = ss.PostStaff(stf);
        //    if(result > 0)
        //    {
        //        return CreatedAtAction(nameof(GetStaffbyId), new {stfId = stf.StaffId}, stf) ;
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}

    }
}
