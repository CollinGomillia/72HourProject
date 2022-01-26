using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72Hour.Reply
{
    public class Reply
    {
        [ForeignKey("Comment")]
        public int Id { get; set; } 

        [Required]
        public string Text { get; set; }

        [Required]
        public Guid AuthorId { get; set; }
    }
}
