﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProBlazorNew.Models
{
    public class Department
    {
        public long DepartmentId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Person> People { get; set; }
    }
}
