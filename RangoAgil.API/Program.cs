using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Context;
using RangoAgil.API.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

var app = builder.Build();

app.MapGet("/", () => "Rango Ágil");

app.MapGet("/rangos", async Task<Results<NoContent, Ok<List<Rango>>>> 
    (RangoDbContext rangoDbContext, 
    [FromQuery(Name = "name")] string? rangoNome) =>
{
    var rangosEntity =  await rangoDbContext.Rangos
                               .Where(r => rangoNome == null || r.Nome.ToLower().Contains(rangoNome.ToLower()))
                               .ToListAsync();

    if (rangosEntity.Count <= 0 || rangosEntity == null)
    {
        return TypedResults.NoContent();
    }
    else 
    {
        return TypedResults.Ok(rangosEntity);
    }
});

app.MapGet("/rango/{id:int}", async (RangoDbContext rangoDbContext, int id) =>
{
    return await rangoDbContext.Rangos.FirstOrDefaultAsync(r => r.Id == id);
});

app.Run();
