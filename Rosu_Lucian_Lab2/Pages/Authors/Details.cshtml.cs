﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rosu_Lucian_Lab2.Data;
using Rosu_Lucian_Lab2.Models;

namespace Rosu_Lucian_Lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Rosu_Lucian_Lab2.Data.Rosu_Lucian_Lab2Context _context;

        public DetailsModel(Rosu_Lucian_Lab2.Data.Rosu_Lucian_Lab2Context context)
        {
            _context = context;
        }

        public Author Authors { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authors = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);
            if (authors == null)
            {
                return NotFound();
            }
            else
            {
                Authors = authors;
            }
            return Page();
        }
    }
}
