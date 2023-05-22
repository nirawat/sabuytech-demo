using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class EFDataContext: DbContext {
        public EFDataContext(DbContextOptions < EFDataContext > options): base(options) {}
        public DbSet <Members> Members { get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Members>()
                .HasKey(members => new { members.Memid });
        }

    }
}