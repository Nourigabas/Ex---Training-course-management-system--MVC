using Ex___Training_course_management_system__MVC.DBContext;
using Ex___Training_course_management_system__MVC.Models;
using Ex___Training_course_management_system__MVC.Repository.CourseRepo;
using Ex___Training_course_management_system__MVC.Repository.InstructorRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Ex___Training_course_management_system__MVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository CourseRepo;
        private readonly IInstructorRepository InstructorRepo;

        public CourseController(ICourseRepository CourseRepo, 
                                IInstructorRepository InstructorRepo)
        {
            this.CourseRepo = CourseRepo;
            this.InstructorRepo = InstructorRepo;
        }

        public IActionResult Index()
        {
            var Courses = CourseRepo.GetCourses();
            return View(Courses);
        }

        public IActionResult Create()
        {
            var instructorNames = InstructorRepo.GetInstructors().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            }).ToList();

            instructorNames.Add(new SelectListItem { Text = "None", Value = Guid.Empty.ToString() });

            ViewBag.Instructors = instructorNames;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (course.InstructorId == Guid.Empty)
            {
                return RedirectToAction("Create", "Instructor");
            }
            CourseRepo.CreateCourse(course);
            return RedirectToAction(nameof(Index));

        }

        [Route("Edit/{id:guid}")]
        public IActionResult Edit(Guid id)
        {
            var course = CourseRepo.GetCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Edit(Guid id, Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }

            var existingCourse = CourseRepo.GetCourse(id);
            if (existingCourse == null)
            {
                return NotFound();
            }

            CourseRepo.UpdateCourse(course, id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid id)
        {
            var course = CourseRepo.GetCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var course = CourseRepo.GetCourse(id);
            CourseRepo.DeleteCourse(id);
            return RedirectToAction(nameof(Index));
        }
    }
}