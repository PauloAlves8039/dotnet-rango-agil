using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Context;
using RangoAgil.API.Entities;
using RangoAgil.API.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.MapGet("/", () => "Rango Ágil");

app.MapGet("/rangos", async Task<Results<NoContent, Ok<IEnumerable<RangoDTO>>>> 
    (RangoDbContext rangoDbContext,
    IMapper mapper,
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
        return TypedResults.Ok(mapper.Map<IEnumerable<RangoDTO>>(rangosEntity));
    }
});

app.MapGet("/rangos/{rangoId:int}/ingredientes", async (
    RangoDbContext rangoDbContext,
    IMapper mapper,
    int rangoId) => 
{
    return mapper.Map<IEnumerable<IngredienteDTO>> ((await rangoDbContext.Rangos
                               .Include(rango => rango.Ingredientes)
                               .FirstOrDefaultAsync(rango => rango.Id == rangoId))?.Ingredientes);
});

app.MapGet("/rangos/{rangoId:int}", async (
    RangoDbContext rangoDbContext,
    IMapper mapper,
    int rangoId) =>
{
    return mapper.Map<RangoDTO>(await rangoDbContext.Rangos.FirstOrDefaultAsync(r => r.Id == rangoId));
}).WithName("GetRangos");

app.MapPost("/rangos", async Task<CreatedAtRoute<RangoDTO>> (
    RangoDbContext rangoDbContext,
    IMapper mapper, 
    [FromBody] RangoParaCriacaoDTO rangoParaCriacaoDTO
    ) => 
{
    var rangosEntity = mapper.Map<Rango>(rangoParaCriacaoDTO);
    rangoDbContext.Add(rangosEntity);
    await rangoDbContext.SaveChangesAsync();

    var rangoToReturn = mapper.Map<RangoDTO>(rangosEntity);

    return TypedResults.CreatedAtRoute(rangoToReturn, "GetRangos", new { rangoId = rangoToReturn.Id });
});

app.MapPut("/rangos/{rangoId:int}", async Task<Results<NotFound, Ok>> (
    RangoDbContext rangoDbContext,
    IMapper mapper,
    int rangoId,
    [FromBody] RangoParaAtualizacaoDTO rangoParaAtualizacaoDTO) =>
{
    var rangosEntity = await rangoDbContext.Rangos.FirstOrDefaultAsync(r => r.Id == rangoId);

    if (rangosEntity == null) 
    {
        return TypedResults.NotFound();
    }

    mapper.Map(rangoParaAtualizacaoDTO, rangosEntity);

    await rangoDbContext.SaveChangesAsync();

    return TypedResults.Ok();
});

app.MapDelete("/rangos/{rangoId:int}", async Task<Results<NotFound, NoContent>> (
        RangoDbContext rangoDbContext,
        int rangoId
    ) =>
{
    var rangosEntity = await rangoDbContext.Rangos.FirstOrDefaultAsync(r => r.Id == rangoId);

    if (rangosEntity == null)
    {
        return TypedResults.NotFound();
    }

    rangoDbContext.Rangos.Remove(rangosEntity);

    await rangoDbContext.SaveChangesAsync();

    return TypedResults.NoContent();
});

app.Run();
