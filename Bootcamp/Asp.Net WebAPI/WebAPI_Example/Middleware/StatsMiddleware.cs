namespace ExampleWebAPI.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class StatsMiddleware
    {
        private readonly RequestDelegate _next;

        public StatsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            DateTime requestTime = DateTime.Now;
            var result = _next(httpContext);
            DateTime responseTime = DateTime.Now;
            TimeSpan proccessDuration = responseTime - requestTime;
            Console.WriteLine("Process duration= " + proccessDuration.TotalMicroseconds + "ms");
            return result;
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class StatsMiddlewareExtensions
    {
        public static IApplicationBuilder UseStatsMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<StatsMiddleware>();
        }
    }
}
