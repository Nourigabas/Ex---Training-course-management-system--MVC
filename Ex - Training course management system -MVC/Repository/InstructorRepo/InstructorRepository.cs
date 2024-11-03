using Ex___Training_course_management_system__MVC.DBContext;
using Ex___Training_course_management_system__MVC.Models;

namespace Ex___Training_course_management_system__MVC.Repository.InstructorRepo
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly DataBaseContext DB;

        public InstructorRepository(DataBaseContext DB)
        {
            this.DB = DB;
        }
        public void CreateInstructor(Instructor instructor)
        {
            DB.Instructors.Add(instructor);
            DB.SaveChanges();
        }

        public List<Instructor> GetInstructors()
        {
            var respone = DB.Instructors.ToList();
            return respone;
        }
    }
}
