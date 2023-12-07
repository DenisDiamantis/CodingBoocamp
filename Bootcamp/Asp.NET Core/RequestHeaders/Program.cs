var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


app.Run(async (HttpContext context) =>
{
    context.Response.Headers["Content-type"] = "text/html";

    if (context.Request.Headers.ContainsKey("User-Agent"))
    {

        string userAgent = context.Request.Headers["User-Agent"];
        await context.Response.WriteAsync($"<p>{userAgent}</p>");
    }

    //custom header
    if (context.Request.Headers.ContainsKey("AuthorizationKey"))
    {

        string authorizationKey = context.Request.Headers["AuthorizationKey"];
        await context.Response.WriteAsync($"<p>{authorizationKey}</p>");
    }
});

app.Run();
