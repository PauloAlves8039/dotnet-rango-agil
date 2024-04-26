using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Context;
using RangoAgil.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.MapGet("/", () => "Rango Ágil");

app.RegisterRangosEndpoints();
app.RegisterIngredientesEndpoints();

app.Run();
