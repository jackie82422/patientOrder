namespace patientOrders;

public class ExceptionMiddleware : IMiddleware
{
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync($"An unexpected error occurred: {ex.Message}");
            }
        }
}