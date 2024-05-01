using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Context;
using RangoAgil.API.Entities;
using RangoAgil.API.Models;

namespace RangoAgil.API.Handlers;

public static class RangosHandlers
{
    public static async Task<Results<NoContent, Ok<IEnumerable<RangoDTO>>>> GetRangosAsync
    (RangoDbContext rangoDbContext,
    IMapper mapper,
    ILogger<RangoDTO> logger,
    [FromQuery(Name = "name")] string? rangoNome)
    {
        var rangosEntity = await rangoDbContext.Rangos
                                                .Where(r => rangoNome == null || r.Nome.ToLower().Contains(rangoNome.ToLower()))
                                                .ToListAsync();

        if (rangosEntity.Count <= 0 || rangosEntity == null)
        {
            logger.LogInformation($"Lista de Rangos não encontrada: {rangosEntity}");
            return TypedResults.NoContent();
        }
        else 
        {
            logger.LogInformation($"Retornando lista de Rangos: {rangosEntity}");
            return TypedResults.Ok(mapper.Map<IEnumerable<RangoDTO>>(rangosEntity));
        }
    }

    public static async Task<Results<NotFound, Ok<RangoDTO>>> GetRangoById
    (RangoDbContext rangoDbContext,
     IMapper mapper,
     ILogger<RangoDTO> logger,
     int rangoId)
    {
        var rangosEntity = await rangoDbContext.Rangos.FirstOrDefaultAsync(x => x.Id == rangoId);

        if (rangosEntity == null) 
        {
            logger.LogInformation($"Rango por Id não encontrado: {rangoId}");
            return TypedResults.NotFound();
        }
            

        return TypedResults.Ok(mapper.Map<RangoDTO>(await rangoDbContext.Rangos.FirstOrDefaultAsync(x => x.Id == rangoId)));
    }

    public static async Task<CreatedAtRoute<RangoDTO>> CreateRangoAsync
    (RangoDbContext rangoDbContext,
     IMapper mapper,
     [FromBody] RangoParaCriacaoDTO rangoParaCriacaoDTO
    )
    {
        var rangosEntity = mapper.Map<Rango>(rangoParaCriacaoDTO);
        rangoDbContext.Add(rangosEntity);
        await rangoDbContext.SaveChangesAsync();

        var rangoToReturn = mapper.Map<RangoDTO>(rangosEntity);

        return TypedResults.CreatedAtRoute(rangoToReturn, "GetRangos", new { rangoId = rangoToReturn.Id });
    }

    public static async Task<Results<NotFound, Ok>> UpdateRangoAsync
    (RangoDbContext rangoDbContext,
     IMapper mapper,
     ILogger<RangoDTO> logger,
     int rangoId,
     [FromBody] RangoParaAtualizacaoDTO rangoParaAtualizacaoDTO)
    {
        var rangosEntity = await rangoDbContext.Rangos.FirstOrDefaultAsync(r => r.Id == rangoId);

        if (rangosEntity == null) 
        {
            logger.LogInformation($"Não foi possível atualizar Rango com Id: {rangoId}");
            return TypedResults.NotFound();
        }

        mapper.Map(rangoParaAtualizacaoDTO, rangosEntity);

        await rangoDbContext.SaveChangesAsync();

        return TypedResults.Ok();
    }

    public static async Task<Results<NotFound, NoContent>> DeleteRangoAsync
    (RangoDbContext rangoDbContext,
     ILogger<RangoDTO> logger,
     int rangoId)
    {
        var rangosEntity = await rangoDbContext.Rangos.FirstOrDefaultAsync(r => r.Id == rangoId);

        if (rangosEntity == null)
        {
            logger.LogInformation($"Não foi possível excluir Rango com Id: {rangoId}");
            return TypedResults.NotFound();
        }

        rangoDbContext.Rangos.Remove(rangosEntity);

        await rangoDbContext.SaveChangesAsync();

        return TypedResults.NoContent();
    }
}
