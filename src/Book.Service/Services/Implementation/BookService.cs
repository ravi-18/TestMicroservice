using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book.Service.CustomModels;
using Book.Service.Data;
using Book.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Book.Service.Services.Implementation
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ResponseBooks>> GetBooksAsync()
        {
            try
            {
                var books =
                await _context.Books.Select(e => new ResponseBooks{
                    Id = e.Id,
                    Title = e.Title,
                    Year = e.Year
                }).ToListAsync();
                return books;
            }
            catch (System.Exception ex)
            {
                throw new ExecutionEngineException(ex.Message, ex.InnerException);
            }
        }

        public async Task<ResponseDetailBook> GetBookByIdAsync(Guid id)
        {
            try
            {     
                var books = await _context.Books
                        .Include(e => e.Author)
                        .Include(e => e.Categories)
                        .Include(e => e.BookPublishers)
                        .ThenInclude(e => e.Publisher)
                        .SingleOrDefaultAsync(e=> e.Id.Equals(id));
                return new ResponseDetailBook{
                    Id = books.Id,
                    Title = books.Title,
                    Year = books.Year,
                    Author = books.Author,
                    Categories = books.Categories,
                    Pubishers = books.BookPublishers.Select(e => e.Publisher).ToList(),
                };
            }
            catch (System.Exception ex)
            {
                throw new ExecutionEngineException(ex.Message, ex.InnerException);
            }
        }

        public async Task<Books> CreateBookAsync(RegisterBook book)
        {
            try
            {
                var books = new Books{
                    Id = new Guid(),
                    Title = book.Title,
                    Year = book.Year,
                    PublisherId = book.PublisherId,
                    CategoryId = book.CategoryId,
                    AuthorId = book.AuthorId
                };    
                await _context.Books.AddAsync(books);
                await _context.SaveChangesAsync();
                var getBook = await _context.Books.SingleOrDefaultAsync(e => e.Id == books.Id);

                return getBook;
            }
            catch (Exception ex)
            {
                throw new ExecutionEngineException(ex.Message, ex.InnerException);
            }
        }

        public async Task<Books> GetBookByIdAndPubliserIdAsync(Guid id, Guid publisherId)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDetailBook> PutBookAsync(Guid id, ModifyBook putBook)
        {
            if (id != putBook.Id)
            {
                return null;
            }

            var books = new Books{
                Id = id,
                Title = putBook.Title,
                Year = putBook.Year,
                PublisherId = putBook.PublisherId,
                CategoryId = putBook.CategoryId,
                AuthorId = putBook.AuthorId
            };

            _context.Entry(books).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

                var book = await _context.Books
                        .Include(e => e.Author)
                        .Include(e => e.Categories)
                        .Include(e => e.BookPublishers)
                        .ThenInclude(e => e.Publisher)
                        .SingleOrDefaultAsync(e=> e.Id.Equals(id));
                return new ResponseDetailBook{
                    Id = book.Id,
                    Title = book.Title,
                    Year = book.Year,
                    Author = book.Author,
                    Categories = book.Categories,
                    Pubishers = book.BookPublishers.Select(e => e.Publisher).ToList(),
                };
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!BooksExists(id))
                {
                    return null;
                }
                else
                {
                    throw new ExecutionEngineException(ex.Message, ex.InnerException);
                }
            }
        }
        private bool BooksExists(Guid id)
        {
            return _context.Books.Any(e => e.Id == id);
        }

        public async Task<ResponseDetailBook> DeleteAsync(Guid id)
        {
            var deleteBook = await _context.Books.SingleOrDefaultAsync(e => e.Id == id);
            if (deleteBook == null)
            {
                return null;
            }   

            _context.Books.Remove(deleteBook);
            await _context.SaveChangesAsync();

            return new ResponseDetailBook{
                Id = deleteBook.Id,
                Title = deleteBook.Title,
                Year = deleteBook.Year,
                Author = deleteBook.Author,
                Categories = deleteBook.Categories,
                Pubishers = deleteBook.BookPublishers.Select(e => e.Publisher).ToList(),
            };
        }
    }
}