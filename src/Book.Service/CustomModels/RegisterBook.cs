using System;

namespace Book.Service.CustomModels
{
    public class RegisterBook
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Guid PublisherId { get; set; }
        public Guid AuthorId { get; set; }
        public Guid CategoryId { get; set; }
    }
}