using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Design;

using multischema_test.domainA.entities;
using multischema_test.domainB.entities;
using multischema_test.domainA;
using multischema_test.domainB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDomainADBContext(builder.Configuration);

builder.Services.AddDomainBContext(builder.Configuration);

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();


var app = builder.Build();
/*
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<DomainAContext>();
        context.Database.Migrate();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }
}
/*
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<DomainBContext>();
        context.Database.Migrate();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }
}
*/
//app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");
app.MapDomainARouting();
app.MapDomainBRouting();

app.Run();
