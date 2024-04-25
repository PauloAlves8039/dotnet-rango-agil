using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Context;
using RangoAgil.API.Handlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.MapGet("/", () => "Rango Ágil");

var rangoEndPoints = app.MapGroup("/rangos");
var rangoIdEndPoints = rangoEndPoints.MapGroup("{rangoId:int}");
var ingredientesEndPoints = rangoIdEndPoints.MapGroup("/ingredientes");

rangoEndPoints.MapGet("", RangosHandlers.GetRangosAsync);

ingredientesEndPoints.MapGet("", IngredientesHandlers.GetIngredientesAsync);

rangoIdEndPoints.MapGet("", RangosHandlers.GetRangoById).WithName("GetRangos");

rangoEndPoints.MapPost("", RangosHandlers.CreateRangoAsync);

rangoIdEndPoints.MapPut("", RangosHandlers.UpdateRangoAsync);

rangoIdEndPoints.MapDelete("", RangosHandlers.DeleteRangoAsync);

app.Run();
