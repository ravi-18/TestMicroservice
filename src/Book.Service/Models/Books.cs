using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Service.Models
{
    public class Books
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public Guid PublisherId { get; set; }
        public virtual ICollection<BookPublisher> BookPublishers { get; set; }
        public Guid AuthorId { get; set; }
        public virtual AuthorViewModel Author { get; set; }
        public Guid CategoryId { get; set; }
        public virtual ICollection<CategoryViewModel> Categories { get; set; }
    }
}