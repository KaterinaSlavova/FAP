using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Model;

namespace WebApp.Pages.Health
{
    public class DetailsModel : PageModel
    {
        private readonly Data.Context _context;

        public DetailsModel(Data.Context context)
        {
            _context = context;
        }

      public Information Information { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Infs == null)
            {
                return NotFound();
            }

            var information = await _context.Infs.FirstOrDefaultAsync(m => m.Id == id);
            if (information == null)
            {
                return NotFound();
            }
            else 
            {
                Information = information;
            }
            return Page();
        }
    }
}
