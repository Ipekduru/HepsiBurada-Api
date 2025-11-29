using Microsoft.AspNetCore.Http;
using SendGrid.Helpers.Errors.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Application.Exceptions
{
    public class ExxceptionMiddleware : IMiddleware
    {
        async Task IMiddleware.InvokeAsync(HttpContext httpContext, RequestDelegate next)
        {
            try
            {
                //httpcontextimi next ile beraber geçirmeye çalısıyorum eğere geçmezse hata alıyorsam exceptiona düşer 
                await next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext,ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            int statusCode = GetStatusCode(exception);
            // kişiye swaggerla ya da postmanla JSON data döneceğimiz için 
            // öncelikli olark http contextten dönen responsun content typeını belirtmem gerekli 
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;

            // errorlar listelenedi 
            List<string> errors = new()
            {
                $"Hata Mesajı : {exception.Message}",
                $"Mesaj Açıklaması : {exception.InnerException?.ToString()}"
            };
            return httpContext.Response.WriteAsync(new ExceptinModel
            {
                Errors = errors,
                StatusCode = statusCode
            }.ToString());//tostring çağırıldığında exception modelde nu serilaize eder 
        

        }
        // durum kodlarının bulunacağı sınıf
        private static int GetStatusCode(Exception exception) =>
            exception switch
            {
                BadRequestException => StatusCodes.Status400BadRequest,
                NotFoundException => StatusCodes.Status404NotFound,
                ValidationException => StatusCodes.Status422UnprocessableEntity,
                _ => StatusCodes.Status500InternalServerError

            };


    }
}
