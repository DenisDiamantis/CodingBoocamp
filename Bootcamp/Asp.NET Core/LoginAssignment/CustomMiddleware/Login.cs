using Microsoft.Extensions.Primitives;

namespace LoginAssignment.CustomMiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Login
    {
        private readonly RequestDelegate _next;

        public Login(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            if (httpContext.Request.Path == "/" && httpContext.Request.Method == "POST")
            {
                StreamReader reader = new StreamReader(httpContext.Request.Body);
                string body = await reader.ReadToEndAsync();
                Dictionary<string, StringValues> queryDict = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);
                string? email, password = null;

                if (queryDict.ContainsKey("email") && queryDict.ContainsKey("password"))
                {

                    email = queryDict["email"][0];
                    password = queryDict["password"][0];

                    if (email == "denis@hotmail.com" && password == "bootcamp")
                    {
                        httpContext.Response.StatusCode = 200;
                        await httpContext.Response.WriteAsync("Successful login");
                    }
                    else
                    {
                        httpContext.Response.StatusCode = 400;
                        await httpContext.Response.WriteAsync("Invalid login");
                    }

                }
                else if (!queryDict.ContainsKey("email") && queryDict.ContainsKey("password"))
                {
                    httpContext.Response.StatusCode = 400;
                    await httpContext.Response.WriteAsync("Invalid input for 'email'");
                }
                else if (queryDict.ContainsKey("email") && !queryDict.ContainsKey("password"))
                {
                    httpContext.Response.StatusCode = 400;
                    await httpContext.Response.WriteAsync("Invalid input for 'password'");
                }
                else
                {
                    httpContext.Response.StatusCode = 400;
                    await httpContext.Response.WriteAsync("Invalid input for 'email'\nInvalid input for 'password'");
                }


            }
            else if (httpContext.Request.Path == "/" && httpContext.Request.Method == "GET")
            {
                httpContext.Response.StatusCode = 200;
            }
            else
            {
                httpContext.Response.StatusCode = 400;
                await httpContext.Response.WriteAsync("Invalid path or Method...");
            }
            //no next operation for this assignment
            //await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LoginExtensions
    {
        public static IApplicationBuilder UseLogin(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Login>();
        }
    }
}
