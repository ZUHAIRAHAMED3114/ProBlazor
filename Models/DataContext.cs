using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProBlazorNew.Models
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts):base(opts) { 
        }

        public DbSet<Person> Peoples { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        
    }
}
