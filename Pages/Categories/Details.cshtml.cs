using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LAB2_gaftone_delia.Data;
using LAB2_gaftone_delia.Models;

namespace LAB2_gaftone_delia.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly LAB2_gaftone_delia.Data.LAB2_gaftone_deliaContext _context;

        public DetailsModel(LAB2_gaftone_delia.Data.LAB2_gaftone_deliaContext context)
        {
            _context = context;
        }

      public Category Category { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
