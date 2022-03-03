using MyWebAPICore.ExceptionHandler;
using System.Net;
using System.Text.Json;

namespace MyWebAPICore
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var result = JsonSerializer.Serialize(new { message = error?.Message });

                switch (error)
                {
                    case BookServiceExceptionHandler e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        result = JsonSerializer.Serialize(new { e.Errors });
                        break;
                    case TransactionExceptionHandler e:
                        response.StatusCode= (int)HttpStatusCode.BadRequest;
                        result = JsonSerializer.Serialize(new { e.Error });
                        break;
                    case KeyNotFoundException e:
                        // not found error
                        response.StatusCode= (int)HttpStatusCode.NotFound;
                        break;
                    default:
                        // unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                await response.WriteAsync(result);

            }
        }
    }
}
