using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Cohort
    {
        public int Id { get; set; }
        [Required]
        [StringLength(11, MinimumLength = 2)]
        public string Name { get; set; }

        public List<Student> Students { get; } = new List<Student>();
        public List<Instructor> Instructors { get; } = new List<Instructor>();
    }
}
