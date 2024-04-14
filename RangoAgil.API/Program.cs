using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
