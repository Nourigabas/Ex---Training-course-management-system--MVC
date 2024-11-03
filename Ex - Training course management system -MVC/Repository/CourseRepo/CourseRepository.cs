using Ex___Training_course_management_system__MVC.DBContext;
using Ex___Training_course_management_system__MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex___Training_course_management_system__MVC.Repository.CourseRepo
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataBaseContext DB;

        public CourseRepository(DataBaseContext DB)
        {
            this.DB = DB;
        }
        public void CreateCourse(Course course)
        {
            DB.Courses.Add(course);
            DB.SaveChanges();
        }

        public void DeleteCourse(Guid Id)
        {
            var respone = DB.Courses.Where(c => c.Id == Id)
                                    .FirstOrDefault();
            respone!.IsDelete = true;
            DB.SaveChanges();
        }

        public Course GetCourse(Guid Id)
        {
            var respone = DB.Courses.Where(c => c.Id == Id&!c.IsDelete)
                                    .Include(e => e.Instructor)
                                    .FirstOrDefault();
            return respone;
        }

        public List<Course> GetCourses()
        {
            var respone = DB.Courses.Where(c => !c.IsDelete)
                                    .Include(e => e.Instructor)
                                    .ToList();
            return respone;
        }

        public void UpdateCourse(Course course, Guid Id)
        {
            var respone = DB.Courses.Where(c => c.Id == Id & !c.IsDelete)
                                    .FirstOrDefault();
            respone!.Name = course.Name;
            respone.Description = course.Description;
            respone.StartDate = course.StartDate;
            respone.EndDate = course.EndDate;
            respone.DurationHours = course.DurationHours;
            DB.SaveChanges();
        }
    }
}
