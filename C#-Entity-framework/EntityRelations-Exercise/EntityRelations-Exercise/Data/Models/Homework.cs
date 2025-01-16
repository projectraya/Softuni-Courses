using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityRelations_Exercise.Data.Models
{
    public class Homework
    {
        [Key]
        public int HomeworkId { get; set; }
        public string Content { get; set; }

        public string ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }

        
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        ICollection<Homework> HomeworkSubmissions = new List<Homework>();
    }
}
