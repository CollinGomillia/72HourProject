using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourProject.Data
{
    public class Comment
    {
        [Key]
        public int Id { get; set; } 
        public string Text { get; set; }
        public Guid AuthorId { get; set; }
        // virtual list of replies
        // foreign key for post
    }
}
