using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LAB2_gaftone_delia.Data;
using LAB2_gaftone_delia.Models;

namespace LAB2_gaftone_delia.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly LAB2_gaftone_delia.Data.LAB2_gaftone_deliaContext _context;

        public CreateModel(LAB2_gaftone_delia.Data.LAB2_gaftone_deliaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Author == null || Author == null)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
