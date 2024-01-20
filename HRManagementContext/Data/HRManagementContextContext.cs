using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRManagement.Models;

namespace HRManagementContext.Data
{
    public class HRManagementContextContext : DbContext
    {
        public HRManagementContextContext (DbContextOptions<HRManagementContextContext> options)
            : base(options)
        {
        }

        public DbSet<HRManagement.Models.Employee> Employee { get; set; } = default!;

        public DbSet<HRManagement.Models.Department> Department { get; set; } = default!;
    }
}
