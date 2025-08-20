using AsPNetCoreWebApplication1.Models;
using AsPNetCoreWebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;


namespace AsPNetCoreWebApplication1.Controllers
{
    public class GradeController : Controller
    {
        public IGradeService gs;
        public List<Grade> gradeList;
        public GradeController(IGradeService gsobj)
        {
            gs = gsobj;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAllGrades()
        {
            gradeList = gs.GetAllGrades();
            return View(gradeList);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Grade g = gs.GetGradeById(id);
            return View(g);
        }
        [HttpPost]
        public ActionResult Edit(int id,  Grade grd)
        {
            if (grd == null || id != grd.GradeId)
            {
                ViewBag.ErrorMsg = "Grade ID mismatch or missing.";
                return View(grd);
            }
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMsg = "Validation error";
                return View(grd);
            }
            int result = gs.UpdateGrade(id, grd);
            if(result == 0)
            {
                ViewBag.ErrorMsg = "something went wrong!";
                return View(grd);
            }
            return RedirectToAction("GetAllGrades");
        }
        public ActionResult Create(Grade grade)
        {
            
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMsg = "Unable to add record";
                return View(grade);
            }
            int result = gs.AddGrade(grade);
            if(result == 0)
            {
                //ViewBag.ErrorMsg = "something went wrong!";
                ModelState.AddModelError("", "Something went wrong while saving the grade.");

                return View(grade);
            }
            return RedirectToAction("GetAllGrades");

        }
        public ActionResult Delete(int id)
        {
            int result = gs.DeleteGrade(id);
            if(result == 0)
            {
                ViewBag.ErrorMsg = "can't delete..something went wrong";
            }
            return RedirectToAction("GetAllGrades");
        }

        public ActionResult Details(int id)
        {
            Grade grade = gs.GetGradeById(id);  
            return View(grade);
        }
        [HttpGet]
        public ActionResult GetGradeByIdAndName(int id, string name)
        {
            Grade grade = gs.GetGradeByIdAndName(id, name);
            if (grade == null)
            {
                ViewBag.ErrorMsg = "No grade found with the given ID and name.";
                return View();
            }
            return View(grade); 
        }
    }
}
