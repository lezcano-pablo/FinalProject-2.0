using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacrMeetPlanner.Models;

namespace SacrMeetPlanner.Pages.Meetings
{
    public class IndexModel : PageModel
    {
        private readonly SacrMeetPlanner.Models.SacrMeetPlannerContext _context;

        public IndexModel(SacrMeetPlanner.Models.SacrMeetPlannerContext context)
        {
            _context = context;
        }

        public IList<Meeting> Meeting { get;set; }

        public async Task OnGetAsync()
        {
            Meeting = await _context.Meeting.ToListAsync();
        }
    }
}
