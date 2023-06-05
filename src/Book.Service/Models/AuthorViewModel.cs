using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Service.Models
{
    public class AuthorViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Guid BookId { get; set; }
        public virtual Books BookAuthors { get; set; }
    }
}