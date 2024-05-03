﻿using RangoAgil.API.Filters;
using RangoAgil.API.Handlers;

namespace RangoAgil.API.Extensions;

public static class EndpointRouteBuilderExtensions
{
    public static void RegisterRangosEndpoints(this IEndpointRouteBuilder endpointRouteBuilder) 
    {
        var rangosEndPoints = endpointRouteBuilder.MapGroup("/rangos");
        var rangoIdEndPoints = rangosEndPoints.MapGroup("{rangoId:int}");

        var rangosComIdAndLockFilterEndpoints = endpointRouteBuilder.MapGroup("/rangos/{rangoId:int}")
            .AddEndpointFilter(new RangoIsLockedFilter(8))
            .AddEndpointFilter(new RangoIsLockedFilter(12));

        rangosEndPoints.MapGet("", RangosHandlers.GetRangosAsync);

        rangoIdEndPoints.MapGet("", RangosHandlers.GetRangoById).WithName("GetRangos");

        rangosEndPoints.MapPost("", RangosHandlers.CreateRangoAsync)
            .AddEndpointFilter<ValidateAnnotationFilter>();

        rangosComIdAndLockFilterEndpoints.MapPut("", RangosHandlers.UpdateRangoAsync);

        rangosComIdAndLockFilterEndpoints.MapDelete("", RangosHandlers.DeleteRangoAsync)
            .AddEndpointFilter<LogNotFoundResponseFilter>();
    }

    public static void RegisterIngredientesEndpoints(this IEndpointRouteBuilder endpointRouteBuilder) 
    {
        var ingredientesEndPoints = endpointRouteBuilder.MapGroup("/rangos/{rangoId:int}/ingredientes");
        ingredientesEndPoints.MapGet("", IngredientesHandlers.GetIngredientesAsync);
    }
}