using Middleware.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("First_Middleware ");
    await next(context);
});

/*
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync(" Second_Middleware ");
    await next(context);
});
*/

//app.UseMiddleware<MyCustomMiddleware>();

app.UseMyCustomMiddleware();

app.UseHelloCustomMiddleware();

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync(" Last_Middleware");
});

app.Run();
