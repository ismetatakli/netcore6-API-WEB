using Core6App.Core.DTOs;
using Core6App.Service.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;

namespace Core6App.API.Middlewares
{
    public static class UserCustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(cfg =>
            {
                cfg.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var exceptionfeature = context.Features.Get<IExceptionHandlerFeature>();
                    var statusCode = exceptionfeature.Error switch
                    {
                        ClientSideException => 400,
                        _ => 500
                    };
                    context.Response.StatusCode = statusCode;
                    var response = CustomResponseDto<NoContentDto>.Fail(statusCode, exceptionfeature.Error.Message);
                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                });
            });
        }
    }
}
