using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MyWebAPICore.Contracts;

namespace MyWebAPICore.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        // middleware is a single step in the application pipeline
        // this validation will happen before we get into the controller
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errorsInModelState = context.ModelState
                    .Where(x => x.Value.Errors.Count() > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(x => x.ErrorMessage)).ToArray();

                //Console.WriteLine(errorsInModelState);

                var errorResponse = new ErrorResponse();

                foreach (var error in errorsInModelState)
                {
                    foreach (var subError in error.Value)
                    {
                        var ErrorModel = new ErrorModel
                        {
                            FieldName = error.Key,
                            Message = subError
                        };

                        errorResponse.Errors.Add(ErrorModel);
                    }
                }

                //Console.WriteLine(errorResponse);

                context.Result = new BadRequestObjectResult(errorResponse);
                // we need this return otherwise next() would be executed
                return;

            }
            await next();
        }
    }
}
