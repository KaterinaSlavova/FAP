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
    public class IndexModel : PageModel
    {
        private readonly Data.Context _context;

        public IndexModel(Data.Context context)
        {
            _context = context;
        }

        public IList<Information> Information { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Infs != null)
            {
                Information = await _context.Infs.ToListAsync();
            }
        }
    }
}
