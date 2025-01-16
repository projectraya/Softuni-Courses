using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDatabase.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string PostContent { get; set; }

        public int UserId { get; set; }
    }
}
