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
    public class DetailsModel : PageModel
    {
        private readonly SacrMeetPlanner.Models.SacrMeetPlannerContext _context;

        public DetailsModel(SacrMeetPlanner.Models.SacrMeetPlannerContext context)
        {
            _context = context;
        }

        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meeting = await _context.Meeting.FirstOrDefaultAsync(m => m.ID == id);

            if (Meeting == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
