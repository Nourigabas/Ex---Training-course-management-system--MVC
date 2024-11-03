using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ex___Training_course_management_system__MVC.Models
{
    public class Instructor
    {
        public Instructor()
        {
            Id = Guid.NewGuid(); 
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<Course>? Courses { get; set; } = [];
    }
}
