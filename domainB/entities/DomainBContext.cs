using Microsoft.EntityFrameworkCore;

namespace multischema_test.domainB.entities
{
    public class DomainBContext: DbContext
    {
        public DbSet<PersonB> PersonB { get; set; }
        public DbSet<Address> Address { get; set; }
        public DomainBContext(DbContextOptions<DomainBContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DomainB");
            //modelBuilder.Entity<PersonB>().ToTable("PersonB");
        }
    }
}
