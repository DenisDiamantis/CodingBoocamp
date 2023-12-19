var builder = WebApplication.CreateBuilder(args);
//Controllers for control and projection into views
builder.Services.AddControllersWithViews();
var app = builder.Build();

//Razor as html files which means they are static
app.UseStaticFiles();
app.MapControllers();

app.Run();
