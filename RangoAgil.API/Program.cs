using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

var app = builder.Build();

app.MapGet("/", () => "Rango Ágil");

app.MapGet("/rango", async (RangoDbContext rangoDbContext, [FromQuery(Name = "name")] string rangoNome) =>
{
    return await rangoDbContext.Rangos
                               .Where(r => r.Nome.Contains(rangoNome))
                               .ToListAsync();
});

app.MapGet("/rango/{id:int}", async (RangoDbContext rangoDbContext, int id) =>
{
    return await rangoDbContext.Rangos.FirstOrDefaultAsync(r => r.Id == id);
});

app.Run();
