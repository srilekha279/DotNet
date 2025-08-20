using System;
using System.Collections.Generic;

namespace EFDBFirstConsoleApp.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;
}
