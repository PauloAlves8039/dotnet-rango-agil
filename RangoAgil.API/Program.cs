using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Context;
using RangoAgil.API.Extensions;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddProblemDetails();

var app = builder.Build();

app.MapGet("/", () => "Rango Ágil");

if (!app.Environment.IsDevelopment()) 
{
    app.UseExceptionHandler();
}

app.RegisterRangosEndpoints();
app.RegisterIngredientesEndpoints();

app.Run();
