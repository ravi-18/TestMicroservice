using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Publisher.Service.Data;
using Publisher.Service.Models;

namespace Publisher.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PublisherController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Publisher
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Publishers>>> GetPublishers()
        {
            return await _context.Publishers.ToListAsync();
        }

        // GET: api/Publisher/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Publishers>> GetPublishers(Guid id)
        {
            var publishers = await _context.Publishers.FindAsync(id);

            if (publishers == null)
            {
                return NotFound();
            }

            return publishers;
        }

        // PUT: api/Publisher/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublishers(Guid id, Publishers publishers)
        {
            if (id != publishers.Id)
            {
                return BadRequest();
            }

            _context.Entry(publishers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublishersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Publisher
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Publishers>> PostPublishers(Publishers publishers)
        {
            _context.Publishers.Add(publishers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPublishers", new { id = publishers.Id }, publishers);
        }

        // DELETE: api/Publisher/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Publishers>> DeletePublishers(Guid id)
        {
            var publishers = await _context.Publishers.FindAsync(id);
            if (publishers == null)
            {
                return NotFound();
            }

            _context.Publishers.Remove(publishers);
            await _context.SaveChangesAsync();

            return publishers;
        }

        private bool PublishersExists(Guid id)
        {
            return _context.Publishers.Any(e => e.Id == id);
        }
    }
}
