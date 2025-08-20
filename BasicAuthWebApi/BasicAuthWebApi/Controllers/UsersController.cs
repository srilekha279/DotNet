using BasicAuthWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAuthWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        UserService us = null;
        public UsersController(UserDbContext ctr)
        {
            us = new UserService(ctr);
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            //Call service class GetUsers method
            //List<User> Users = ss.GetStaffList();
            //return Users;

            List<User> users = us.GetUserList();
            if (users == null || users.Count == 0)
            {
                return NotFound("No staff records found");
            }
            return Ok(users);
        }

        [HttpGet("GetUserbyId/{id}")]
        public ActionResult<User> GetUserbyId(int id)
        {
            User u = us.GetUserbyId(id);
            if (u == null)
            {
                return NotFound("No staff records found with id " + id);
            }
            return Ok(u);
        }
        [HttpPost("AddUser")]
        public ActionResult<User> AddUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int result = us.AddUser(user);
            if (result > 0)
            {
                return CreatedAtAction(nameof(GetUserbyId), new { id = user.Id }, user);
            }
            return BadRequest("Failed to add user");
        }

        [HttpPut("UpdateUser/{id}")]
        public ActionResult UpdateUser(int id, [FromBody] User user)
        {
            if (id != user.Id)
            {
                return BadRequest("User ID mismatch");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int result = us.UpdateUser(user);
            if (result > 0)
            {
                return Ok("User updated successfully");
            }
            return NotFound("User not found");
        }
        [HttpDelete("DeleteUser/{id}")]
        public ActionResult DeleteUser(int id)
        {
            int result = us.DeleteUser(id);
            if (result > 0)
            {
                return Ok("User deleted successfully");
            }
            return NotFound("User not found");
        }
    }

}
