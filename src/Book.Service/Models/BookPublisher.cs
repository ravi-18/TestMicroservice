using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Service.Models
{
    public class BookPublisher
    {
        public Guid BookId { get; set; }
        public virtual Books Book { get; set; }
        public Guid PublisherId { get; set; }
        public virtual PubisherViewModel Publisher { get; set; }
    }
}