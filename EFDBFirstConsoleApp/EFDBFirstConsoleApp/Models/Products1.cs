using System;
using System.Collections.Generic;

namespace EFDBFirstConsoleApp.Models;

public partial class Products1
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
