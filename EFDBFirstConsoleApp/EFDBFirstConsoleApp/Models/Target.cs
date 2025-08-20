using System;
using System.Collections.Generic;

namespace EFDBFirstConsoleApp.Models;

public partial class Target
{
    public int TargetId { get; set; }

    public decimal Percentage { get; set; }

    public virtual ICollection<Commission> Commissions { get; set; } = new List<Commission>();
}
