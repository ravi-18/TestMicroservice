using System.Collections.Generic;
using Book.Service.Models;

namespace Book.Service.CustomModels
{
    public class ResponseDetailBook : ResponseBooks
    {
        public IEnumerable<PubisherViewModel> Pubishers { get; set; }
        public AuthorViewModel Author { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}