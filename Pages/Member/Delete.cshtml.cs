using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Modi_Naomi_Lab2.Data;
using Modi_Naomi_Lab2.Models;

namespace Modi_Naomi_Lab2.Pages.Member
{
    public class DeleteModel : PageModel
    {
        private readonly Modi_Naomi_Lab2.Data.Modi_Naomi_Lab2Context _context;

        public DeleteModel(Modi_Naomi_Lab2.Data.Modi_Naomi_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Modi_Naomi_Lab2.Models.Member Member { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FirstOrDefaultAsync(m => m.ID == id);

            if (member == null)
            {
                return NotFound();
            }
            else
            {
                Member = member;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FindAsync(id);
            if (member != null)
            {
                Member = member;
                _context.Member.Remove(Member);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
