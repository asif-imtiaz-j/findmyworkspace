using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DIS6225_FinalProject_MVC.Models;

namespace findmyworkspace.Data
{
    public class findmyworkspaceContext : DbContext
    {
        public findmyworkspaceContext (DbContextOptions<findmyworkspaceContext> options)
            : base(options)
        {
        }

        public DbSet<DIS6225_FinalProject_MVC.Models.Location> Location { get; set; } = default!;
        public DbSet<DIS6225_FinalProject_MVC.Models.Review> Review { get; set; } = default!;
    }
}
