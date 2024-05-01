using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Context;
using RangoAgil.API.Models;

namespace RangoAgil.API.Handlers;

public static class IngredientesHandlers
{
    public static async Task<Results<NotFound, Ok<IEnumerable<IngredienteDTO>>>> GetIngredientesAsync(
    RangoDbContext rangoDbContext,
    IMapper mapper,
    ILogger<RangoDTO> logger,
    int rangoId)
    {
        var rangosEntity = await rangoDbContext.Rangos.FirstOrDefaultAsync(x => x.Id == rangoId);

        if (rangosEntity == null) 
        {
            logger.LogInformation($"Não foram encontrados Ingredientes para o Rango com Id: {rangoId}");
            return TypedResults.NotFound();
        }
            

        return TypedResults.Ok(mapper.Map<IEnumerable<IngredienteDTO>>((await rangoDbContext.Rangos
                           .Include(rango => rango.Ingredientes)
                           .FirstOrDefaultAsync(rango => rango.Id == rangoId))?.Ingredientes));
    }
}