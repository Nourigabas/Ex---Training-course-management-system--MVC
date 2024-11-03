using Ex___Training_course_management_system__MVC.Models;

namespace Ex___Training_course_management_system__MVC.Repository.CourseRepo
{
    public interface ICourseRepository
    {
        List<Course> GetCourses();
        Course GetCourse(Guid Id);
        void CreateCourse(Course course);
        void UpdateCourse(Course course, Guid Id);
        void DeleteCourse(Guid Id);
    }
}
