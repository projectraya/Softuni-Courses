using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityRelations_Exercise.Data.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public bool RegisteredOn { get; set; }
        public DateTime Birthday { get; set; }

        //ICollection<Course> CourseEnrollments = new List<Course>(); //should be in many to many
        ICollection<Homework> HomeworkSubmissions = new List<Homework>();
    }
}
