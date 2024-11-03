using Ex___Training_course_management_system__MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex___Training_course_management_system__MVC.DBContext
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Training_course_management_system");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>().HasData(
               new Instructor
               {
                   Id = Guid.Parse("c100db04-6046-40e6-889f-7a4456ffd460"),
                   Name = "John Smith",
                   Email = "john.smith@example.com"
               },
               new Instructor
               {
                   Id = Guid.Parse("fd645597-2daa-42f7-ad88-ed0766345c56"),
                   Name = "Emma Johnson",
                   Email = "emma.johnson@example.com"
               },
               new Instructor
               {
                   Id = Guid.Parse("4053f11d-e58c-4354-9af3-e05a512203ec"),
                   Name = "Michael Brown",
                   Email = "michael.brown@example.com"
               });
            modelBuilder.Entity<Course>().HasData(
             new Course
             {
                 Name = "Introduction to Programming",
                 Description = "Learn the basics of programming using C#.",
                 StartDate = new DateTime(2024, 1, 10),
                 EndDate = new DateTime(2024, 3, 15),
                 DurationHours = 40,
                 InstructorId = Guid.Parse("c100db04-6046-40e6-889f-7a4456ffd460")
             },
             new Course
             {
                 Name = "Web Development with ASP.NET",
                 Description = "Build dynamic websites using ASP.NET Core.",
                 StartDate = new DateTime(2024, 4, 1),
                 EndDate = new DateTime(2024, 6, 30),
                 DurationHours = 60,
                 InstructorId = Guid.Parse("fd645597-2daa-42f7-ad88-ed0766345c56")
             },
             new Course
             {
                 Name = "Data Science Basics",
                 Description = "An introduction to data science concepts and tools.",
                 StartDate = new DateTime(2024, 7, 15),
                 EndDate = new DateTime(2024, 9, 15),
                 DurationHours = 50,
                 InstructorId = Guid.Parse("4053f11d-e58c-4354-9af3-e05a512203ec")
             });
        }
    }
}