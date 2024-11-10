using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modi_Naomi_Lab2.Models;

namespace Modi_Naomi_Lab2.Data
{
    public class Modi_Naomi_Lab2Context : DbContext
    {
        public Modi_Naomi_Lab2Context (DbContextOptions<Modi_Naomi_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Modi_Naomi_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Modi_Naomi_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Modi_Naomi_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Modi_Naomi_Lab2.Models.Category> Author { get; set; } = default!;
        public DbSet<Modi_Naomi_Lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Modi_Naomi_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
