using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Model;

namespace WebApp.Pages.Health
{
    public class EditModel : PageModel
    {
        private readonly Data.Context _context;

        public EditModel(Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Information Information { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Informations == null)
            {
                return NotFound();
            }

            var information =  await _context.Informations.FirstOrDefaultAsync(m => m.Id == id);
            if (information == null)
            {
                return NotFound();
            }
            Information = information;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Information).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InformationExists(Information.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InformationExists(int id)
        {
          return (_context.Informations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
