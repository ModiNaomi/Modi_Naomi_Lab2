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
    public class IndexModel : PageModel
    {
        private readonly Modi_Naomi_Lab2.Data.Modi_Naomi_Lab2Context _context;

        public IndexModel(Modi_Naomi_Lab2.Data.Modi_Naomi_Lab2Context context)
        {
            _context = context;
        }

        public IList<Modi_Naomi_Lab2.Models.Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Member = await _context.Member.ToListAsync();
        }
    }
}
