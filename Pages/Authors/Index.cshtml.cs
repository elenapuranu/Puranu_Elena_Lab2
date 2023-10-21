﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Puranu_Elena_Lab2.Data;
using Puranu_Elena_Lab2.Models;

namespace Puranu_Elena_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Puranu_Elena_Lab2.Data.Puranu_Elena_Lab2Context _context;

        public IndexModel(Puranu_Elena_Lab2.Data.Puranu_Elena_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Authors != null)
            {
                Author = await _context.Authors.ToListAsync();
            }
        }
    }
}
