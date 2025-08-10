﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal class LinqProject
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? ProjectId { get; set; }
    }
}
