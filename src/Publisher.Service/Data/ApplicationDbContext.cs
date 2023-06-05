using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Publisher.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Publisher.Service.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Publishers> Publishers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
            
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}