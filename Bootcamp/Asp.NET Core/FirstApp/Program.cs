

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run(async (HttpContext context) =>
{

    if (1 == 1)
    {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("Hello ");
        await context.Response.WriteAsync("World");
    }
    else
    {
        context.Response.StatusCode = 400;
    }

});

app.Run();
