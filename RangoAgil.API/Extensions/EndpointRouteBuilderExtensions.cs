using RangoAgil.API.Handlers;

namespace RangoAgil.API.Extensions;

public static class EndpointRouteBuilderExtensions
{
    public static void RegisterRangosEndpoints(this IEndpointRouteBuilder endpointRouteBuilder) 
    {
        var rangoEndPoints = endpointRouteBuilder.MapGroup("/rangos");
        var rangoIdEndPoints = rangoEndPoints.MapGroup("{rangoId:int}");

        rangoEndPoints.MapGet("", RangosHandlers.GetRangosAsync);

        rangoIdEndPoints.MapGet("", RangosHandlers.GetRangoById).WithName("GetRangos");

        rangoEndPoints.MapPost("", RangosHandlers.CreateRangoAsync);

        rangoIdEndPoints.MapPut("", RangosHandlers.UpdateRangoAsync);

        rangoIdEndPoints.MapDelete("", RangosHandlers.DeleteRangoAsync);
    }

    public static void RegisterIngredientesEndpoints(this IEndpointRouteBuilder endpointRouteBuilder) 
    {
        var ingredientesEndPoints = endpointRouteBuilder.MapGroup("/rangos/{rangoId:int}/ingredientes");
        ingredientesEndPoints.MapGet("", IngredientesHandlers.GetIngredientesAsync);
    }
}