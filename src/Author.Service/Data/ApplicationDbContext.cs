using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Author.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Author.Service.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Authors> Authors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
            
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}