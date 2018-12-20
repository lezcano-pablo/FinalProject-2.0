using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SacrMeetPlanner.Models
{
    public class SacrMeetPlannerContext : DbContext
    {
        public SacrMeetPlannerContext (DbContextOptions<SacrMeetPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<SacrMeetPlanner.Models.Meeting> Meeting { get; set; }
    }
}
