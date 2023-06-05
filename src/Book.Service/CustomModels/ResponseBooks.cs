using System;

namespace Book.Service.CustomModels
{
    public class ResponseBooks
    {
        
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}