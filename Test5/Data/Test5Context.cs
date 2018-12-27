using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test5.Models
{
    public class Test5Context : DbContext
    {
        public Test5Context (DbContextOptions<Test5Context> options)
            : base(options)
        {
        }

        public DbSet<Test5.Models.Employee> Employee { get; set; }
    }
}
