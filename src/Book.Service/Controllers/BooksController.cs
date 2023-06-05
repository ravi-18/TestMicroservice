using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Book.Service.Data;
using Book.Service.Models;
using Book.Service.CustomModels;
using Book.Service.Services;

namespace Book.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IBookService _service;

        public BooksController(ApplicationDbContext context, IBookService service)
        {
            _context = context;
            _service = service;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseBooks>>> GetBooks()
        {
            var books = await _service.GetBooksAsync();
            return books.ToList();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDetailBook>> GetBooks(Guid id)
        {
            var books = await _service.GetBookByIdAsync(id);

            if (books == null)
            {
                return NotFound();
            }

            return books;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooks(Guid id, ModifyBook books)
        {
            var modifyBook = _service.PutBookAsync(id, books);
            if (modifyBook == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(modifyBook);
            }
        }

        // POST: api/Books
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ResponseDetailBook>> PostBooks(RegisterBook books)
        {
            var book = await _service.CreateBookAsync(books);

            return CreatedAtAction("GetBooks", new { id = book.Id }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDetailBook>> DeleteBooks(Guid id)
        {
            var books = await _service.DeleteAsync(id);
            if (books == null)
            {
                return NotFound();
            }

            return books;
        }

        
    }
}
