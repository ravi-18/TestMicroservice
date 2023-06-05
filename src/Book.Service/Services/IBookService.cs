using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Book.Service.CustomModels;
using Book.Service.Models;

namespace Book.Service.Services
{
    public interface IBookService
    {
        public Task<Books> CreateBookAsync(RegisterBook book);
        public Task<IEnumerable<ResponseBooks>> GetBooksAsync();
        public Task<ResponseDetailBook> GetBookByIdAsync(Guid id);
        public Task<Books> GetBookByIdAndPubliserIdAsync(Guid id, Guid publisherId);
        public Task<ResponseDetailBook> PutBookAsync(Guid id, ModifyBook putBook);
        public Task<ResponseDetailBook> DeleteAsync(Guid id);


    }
}