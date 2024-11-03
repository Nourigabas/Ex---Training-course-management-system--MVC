using Ex___Training_course_management_system__MVC.Models;

namespace Ex___Training_course_management_system__MVC.Repository.InstructorRepo
{
    public interface IInstructorRepository
    {
        void CreateInstructor(Instructor instructor);
        List<Instructor> GetInstructors();
    }
}
