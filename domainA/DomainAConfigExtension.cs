using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using multischema_test.domainA.entities;

namespace multischema_test.domainA
{
    public static class DomainAConfigExtension
    {
        public static void AddDomainADBContext(this IServiceCollection services, ConfigurationManager config)
        {
            services.AddDbContext<DomainAContext>(context =>
               //context.UseNpgsql(config.GetConnectionString("DefaultConnection"), opt => opt.MigrationsHistoryTable(
               context.UseSqlServer(config.GetConnectionString("DefaultConnection"), opt => opt.MigrationsHistoryTable(
                 tableName: HistoryRepository.DefaultTableName,
                 schema: "DomainA"
                 )));
        }

        public static void MapDomainARouting(this WebApplication app)
        {
            app.MapGroup("domainA")
                .MapGet("/", () => "Hello From DomainA");
        }
    }
}
