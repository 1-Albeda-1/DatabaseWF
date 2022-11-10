using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStoryAir.Models;

namespace UserStoryAir
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Reys> ReysBD { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                   : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reys>().HasKey(u => u.Id);
        }
       
    }
}
