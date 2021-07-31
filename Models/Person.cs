using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProBlazorNew.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public long DepartmentId { get; set; }
        public long LocationId { get; set; }
        public Department Department { get; set; }
        public Location Location { get; set; } 

        
    }
}
