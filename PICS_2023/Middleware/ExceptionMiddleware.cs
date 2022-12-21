using Microsoft.AspNetCore.Http;
using PICS_2023.Model;
using PICS_2023.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;

namespace PICS_2023.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (CustomException cex)
            {
                await HandleExceptionAsync(httpContext, cex);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            context.Response.StatusCode = exception switch
            {
                CustomException => (int)HttpStatusCode.OK,
                _ => (int)HttpStatusCode.InternalServerError
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(new ResponseDto<string>
            {
                Status = "error",
                Result = string.Empty,
                Message = exception.Message,
            })) ;
        }
    }
}
