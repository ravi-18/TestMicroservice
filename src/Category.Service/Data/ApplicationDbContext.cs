using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Category.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Category.Service.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
            
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}