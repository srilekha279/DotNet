using System;
using System.Collections.Generic;

namespace EFDBFirstConsoleApp.Models;

public partial class Category1
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public decimal? Amount { get; set; }
}
