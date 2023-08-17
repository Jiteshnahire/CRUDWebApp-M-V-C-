using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticalTestMVC.Models;

namespace PracticalTestMVC.Data
{
    public class PracticalTestMVCContext : DbContext
    {
        public PracticalTestMVCContext (DbContextOptions<PracticalTestMVCContext> options)
            : base(options)
        {
        }

        public DbSet<PracticalTestMVC.Models.Department> Department { get; set; } = default!;

        public DbSet<PracticalTestMVC.Models.Employee>? Employee { get; set; }
    }
}
