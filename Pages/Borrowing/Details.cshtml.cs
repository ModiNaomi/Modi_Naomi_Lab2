﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Modi_Naomi_Lab2.Data;
using Modi_Naomi_Lab2.Models;

namespace Modi_Naomi_Lab2.Pages.Borrowing
{
    public class DetailsModel : PageModel
    {
        private readonly Modi_Naomi_Lab2.Data.Modi_Naomi_Lab2Context _context;

        public DetailsModel(Modi_Naomi_Lab2.Data.Modi_Naomi_Lab2Context context)
        {
            _context = context;
        }

        public Modi_Naomi_Lab2.Models.Borrowing Borrowing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else
            {
                Borrowing = borrowing;
            }
            return Page();
        }
    }
}