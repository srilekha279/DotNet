﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBCodeFirstApproach.DTO
{
    internal class StdWithGradeDTO
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
    }
}
