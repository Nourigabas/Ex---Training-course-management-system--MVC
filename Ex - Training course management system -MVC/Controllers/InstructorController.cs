using Ex___Training_course_management_system__MVC.DBContext;
using Ex___Training_course_management_system__MVC.Models;
using Ex___Training_course_management_system__MVC.Repository.InstructorRepo;
using Microsoft.AspNetCore.Mvc;

namespace Ex___Training_course_management_system__MVC.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorRepository InstructorRepo;

        public InstructorController(IInstructorRepository InstructorRepo)
        {
            this.InstructorRepo = InstructorRepo;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                InstructorRepo.CreateInstructor(instructor);
                return RedirectToAction("Index", "Course"); 
            }

            return View(); 
        }
    }
}