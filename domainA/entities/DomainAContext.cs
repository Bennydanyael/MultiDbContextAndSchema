using Microsoft.EntityFrameworkCore;

namespace multischema_test.domainA.entities
{
    public class DomainAContext : DbContext
    {
        public DbSet<PersonA>  PersonA { get; set; }

        public DomainAContext(DbContextOptions<DomainAContext> options): base(options) { }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DomainA");
            modelBuilder.Entity<PersonA>().ToTable("PersonA");
        }
    }
}
