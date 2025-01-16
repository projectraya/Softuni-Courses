using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDatabase.Models
{
    public class PostAnswer
    {
        public int Id { get; set; }

        public string AnswerContent { get; set; }

        public int PostId { get; set; }
    }
}
