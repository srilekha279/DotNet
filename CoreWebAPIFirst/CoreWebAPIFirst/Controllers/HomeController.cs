using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAPIFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string GetWelcomeMessage()
        {
            return "Hello";
        }
        //Implementing EF in Web API - 
        //Add EF packages - Tools, Design, SqlServer
        //Models Folder  -copy Staff, Store entity classes and DbContext classes

    }
}
