using MiniValidation;
using RangoAgil.API.Models;

namespace RangoAgil.API.Filters;

public class ValidateAnnotationFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var rangoParaCriacaoDTO = context.GetArgument<RangoParaCriacaoDTO>(2);

        if (!MiniValidator.TryValidate(rangoParaCriacaoDTO, out var validationErros)) 
        {
            return TypedResults.ValidationProblem(validationErros);
        }

        return await next(context);
    }
}