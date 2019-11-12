using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Exercise
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Language { get; set; }
        public int Id { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

        public void PrintStudentsAssigned()
        {
            Console.WriteLine($"{Language} {Name}");
            Console.WriteLine($"==================");
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
    }
}
