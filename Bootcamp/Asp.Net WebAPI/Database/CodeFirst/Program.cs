using CodeFirst.Models;
using CodeFirst.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
});
var app = builder.Build();

app.MapGet("/", (ApplicationDbContext context) =>
{
    var product = new Product()
    {
        Name = "Samsung Galazy 24",
        Brand = "Samsung",
        Category = "Phones",
        Price = 999,
        Description = "created using CodeFirst",
        CreatedAT = DateTime.Now
    };
    context.Products.Add(product);
    context.SaveChanges();

    var products = context.Products.ToList();
    return products;
});

app.Run();
