using System;
using System.Collections.Generic;

namespace EFDBFirstConsoleApp.Models;

public partial class DailySale
{
    public DateOnly OrderDate { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? Sales { get; set; }
}
