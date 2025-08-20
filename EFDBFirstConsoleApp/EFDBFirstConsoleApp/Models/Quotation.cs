using System;
using System.Collections.Generic;

namespace EFDBFirstConsoleApp.Models;

public partial class Quotation
{
    public int QuotationNo { get; set; }

    public DateOnly ValidFrom { get; set; }

    public DateOnly ValidTo { get; set; }

    public decimal Amount { get; set; }

    public string? CustomerName { get; set; }
}
