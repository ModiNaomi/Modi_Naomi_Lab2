using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Modi_Naomi_Lab2.Data;
using Modi_Naomi_Lab2.Models;

namespace Modi_Naomi_Lab2.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Modi_Naomi_Lab2.Data.Modi_Naomi_Lab2Context _context;

        public CreateModel(Modi_Naomi_Lab2.Data.Modi_Naomi_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookID"] = new SelectList(_context.Book, "ID", "ID");
        ViewData["MemberID"] = new SelectList(_context.Member, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Modi_Naomi_Lab2.Models.Borrowing Borrowing { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Borrowing.Add(Borrowing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
