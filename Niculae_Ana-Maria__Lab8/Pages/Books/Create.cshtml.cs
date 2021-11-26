using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Niculae_Ana_Maria_Lab8.Data;
using Niculae_Ana_Maria_Lab8.Models;

namespace Niculae_Ana_Maria_Lab8.Models.Books
{
    public class CreateModel : PageModel
    {
        private readonly Niculae_Ana_Maria_Lab8.Data.Niculae_Ana_Maria_Lab8Context _context;

        public CreateModel(Niculae_Ana_Maria_Lab8.Data.Niculae_Ana_Maria_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
