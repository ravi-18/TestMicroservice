using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Service.Models
{
    public class PubisherViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } 
        public virtual ICollection<BookPublisher> BookPublishers { get; set; }
    }
}