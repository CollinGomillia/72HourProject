using _72HourProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourProject.Services
{
    public class CommentService
    {
        private readonly Guid _userId;

        public CommentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new CommentCreate()
                {
                    Text = model.Text,
                    AuthorId = _userId
                };

            using (var ctx = new ApplicationDbContext())
            {
                // need to connect db
            }
        }
    }
}
