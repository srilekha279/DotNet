using System;
using System.Collections.Generic;

namespace EFDBFirstConsoleApp.Models;

public partial class SalesSalesVisit
{
    public int VisitId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? VisitedAt { get; set; }

    public string? Phone { get; set; }
}
