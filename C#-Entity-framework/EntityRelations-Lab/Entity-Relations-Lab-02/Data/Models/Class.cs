using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Relations_Lab_02.Data.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        ICollection<Student> Students = new List<Student>();
    }
}
