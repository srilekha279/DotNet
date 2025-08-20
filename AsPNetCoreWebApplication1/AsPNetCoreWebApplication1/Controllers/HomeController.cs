using AsPNetCoreWebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AsPNetCoreWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public string MyStringReturnFunction()
        {
            return "This is a random string";
        }
        public ViewResult About()
        {
            return View();
        }
        public ContentResult MyContent()
        {
            return Content("Current directory: " + Directory.GetCurrentDirectory());
            return Content("Hello");
        }
        public FileResult MyFileResult()
        {
            return File("files/file1.txt", "text/plain");
            //return File("css/site.css", "text/plain");

            string path = Path.Combine(Directory.GetCurrentDirectory(), "Controllers", "HomeController.cs");
            byte[] fileBytes = System.IO.File.ReadAllBytes(path);
            //File will be displayed
            //return File(path, "text/plain");
            //File will be downloaded
            //Third argument is name to display when downloading
            return File(fileBytes, "text/plain", "HomeController.cs");
        }
        public RedirectToActionResult MyRedirectToAction()
        {
            return RedirectToAction("GetAllGrades", "Grade");
            return RedirectToAction("Privacy");
            return RedirectToAction("Privacy", "Home");
        }
        public RedirectResult MyRedirect()
        {
            return Redirect("http://msn.com");
        }
        public RedirectToRouteResult MyRedirectRoute()
        {
            //different controller - required to specify controller name, otherwise - 404 error
            return RedirectToRoute(new { controller = "Grade", action = "GetAllGrades" });
            //same controller - no need to specify controller name
            //return RedirectToRoute(new { action = "Privacy" }); 
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
