using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using multischema_test.domainB.entities;

namespace multischema_test.domainB
{
    public static class DomainBConfigExtension
    {
        public static void AddDomainBContext(this IServiceCollection services, ConfigurationManager config) {

            services.AddDbContext<DomainBContext>(context =>
              //context.UseNpgsql(config.GetConnectionString("DefaultConnection"), opt => opt.MigrationsHistoryTable(
              context.UseSqlServer(config.GetConnectionString("DefaultConnection"), opt => opt.MigrationsHistoryTable(
                tableName: HistoryRepository.DefaultTableName,
                schema: "DomainB"
            )));

        }

        public static void MapDomainBRouting(this WebApplication app)
        {
            var route = app.MapGroup("domainB");
            route.MapGet("/", () => "Hello From DomainB");
            route.MapGet("/test1", () => "hello from domainB test1");
        }
    }
}
