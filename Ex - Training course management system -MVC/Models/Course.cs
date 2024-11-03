using System;
using System.ComponentModel.DataAnnotations;

namespace Ex___Training_course_management_system__MVC.Models
{
    public class Course
    {
        public Course()
        {
            Id = Guid.NewGuid(); // Generate a unique identifier for the course
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Range(1, 1000)]
        public int DurationHours { get; set; }
        public bool IsDelete { get; set; } = false;
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
