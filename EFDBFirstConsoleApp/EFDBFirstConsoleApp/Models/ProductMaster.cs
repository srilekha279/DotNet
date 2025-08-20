using System;
using System.Collections.Generic;

namespace EFDBFirstConsoleApp.Models;

public partial class ProductMaster
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public short ModelYear { get; set; }

    public decimal ListPrice { get; set; }

    public string BrandName { get; set; } = null!;

    public string CategoryName { get; set; } = null!;
}
