using System;
using System.Collections.Generic;

namespace EFDBFirstConsoleApp.Models;

public partial class Taxis
{
    public int TaxId { get; set; }

    public string State { get; set; } = null!;

    public decimal? StateTaxRate { get; set; }

    public decimal? AvgLocalTaxRate { get; set; }

    public decimal? CombinesRate { get; set; }

    public decimal? MaxLocalTaxRate { get; set; }

    public DateTime UpdatedAt { get; set; }
}
