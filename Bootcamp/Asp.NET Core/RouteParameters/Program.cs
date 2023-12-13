var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enable routing
app.UseRouting();

//creating endpoints
app.UseEndpoints(endpoints =>
{
    //route parameters
    endpoints.Map("files/{filename}.{extension}", async (context) =>
    {
        string? filename = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);

        await context.Response.WriteAsync($"In files - {filename} - {extension}");
    });
    //constraits
    endpoints.Map("employee/profile/{employeeName:length(4,7)}", async (context) =>
    {
        string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);

        await context.Response.WriteAsync($"In Employee Profile- {employeeName} ");
    });
    //default value
    //endpoints.Map("products/details/{id=5}", async (context) =>
    endpoints.Map("products/details/{id?}", async (context) =>
    {
        if (context.Request.RouteValues.ContainsKey("id"))
        {
            int? id = Convert.ToInt32(context.Request.RouteValues["id"]);

            await context.Response.WriteAsync($"In product details - {id} ");
        }
        else
        {
            await context.Response.WriteAsync("In product details -id is not supplied ");
        }
    });
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();