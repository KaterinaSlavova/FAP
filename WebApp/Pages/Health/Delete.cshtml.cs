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
    public class DeleteModel : PageModel
    {
        private readonly Data.Context _context;

        public DeleteModel(Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Infs == null)
            {
                return NotFound();
            }
            var information = await _context.Infs.FindAsync(id);

            if (information != null)
            {
                Information = information;
                _context.Infs.Remove(Information);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
