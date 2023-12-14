using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Category { get; set; } = null!;

    public decimal Price { get; set; }

    public string Description { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
